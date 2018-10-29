import time, pyaudio, wave, pyautogui, sys, argparse, re
from array import array
from random import randint


def r():
    return randint(1, 1000)


def point_str(x, y):
    return "(" + str(x) + "," + str(y) + ")"


parser = argparse.ArgumentParser()
parser.add_argument("-i", "--image", metavar="str", type=str, help="bobber image file")
parser.add_argument(
    "-c", "--confidence", metavar="float", type=float, help="start value of confidence rate"
)
parser.add_argument("-l", "--list", action='store_true', help="list sound i/o devices")
parser.add_argument("-s", "--speaker", metavar="int", type=int, help="speaker index")

args = parser.parse_args()

audio = pyaudio.PyAudio()
if(args.list):
    
    info1 = audio.get_default_output_device_info()
    
    out_str = '{ "DeviceList": [ ';
    for i in range(audio.get_device_count()):
        info = audio.get_device_info_by_index(i)
        
        #filter input devices (mic)
        if(info["maxInputChannels"] > 0 or info["maxOutputChannels"] == 0):
            continue
        
        out_str += str(info) + ', '

    out_str = ''.join(re.sub(r'[^a-zA-Z0-9_"{}()\[\],.: \']+', '', out_str.replace("'", '"') + "] }").rsplit(',', 1))
    print(out_str)
    out = open("speakers.json", "w")
    out.write(out_str)
    out.close()
    exit()

check_interval = 0.050  # seconds

# Listener
# region Listener
frames = 512
reset_sound = 1.000  # seconds
sound_length = 0
silence_length = 0
timeout_length = 25.000

stream = None
deviceInfo = {}
device_index = audio.get_default_output_device_info()['index']
if(args.speaker is not None):
    device_index = args.speaker

# endregion


# Bobber
# region Bobber
image = "bobber.png"
search_interval = 1.000  # ~seconds
confidence_start = 0.75

x = 0
y = 0
is_bobber_found = False
is_searching_bobber = False
current_confidence = confidence_start
search_cd = 2.000

def find_bobber():
    global is_bobber_found, search_cd, current_confidence

    if is_bobber_found:
        return

    # we didn't find lure location yet
    if search_cd > 0:
        search_cd -= check_interval
        return

    search_cd = search_interval
    location = pyautogui.locateOnScreen(image, confidence=current_confidence)

    if location is not None:
        x, y = pyautogui.center(location)
        is_bobber_found = True
        print("bobber=" + str(x) + "," + str(y) + ":Bobber found", flush=True)
        current_confidence = confidence_start
    else:
        # lower the confidence rate a little
        if current_confidence > 0.1:
            current_confidence -= 0.05
            print(
                "searchfail="
                + str(current_confidence)
                + ":Bobber not found reduced confidence rate "
                , flush=True
            )


# endregion


# Open stream
try:
    device_info = audio.get_device_info_by_index(device_index)
except IOError:
    print("critical:An error ocurred when retrieving selected device info. Exitting...", flush=True)
    exit()

device_channel_count = (
    device_info["maxInputChannels"]
    if (device_info["maxOutputChannels"] < device_info["maxInputChannels"])
    else device_info["maxOutputChannels"]
)

stream = audio.open(
    format=pyaudio.paInt16,
    channels=device_channel_count,
    rate=int(device_info["defaultSampleRate"]),
    input=True,
    frames_per_buffer=frames,
    input_device_index=device_info["index"],
    as_loopback=True,
)

print("start:Started recording " + str(device_info["name"]), flush=True)
time.sleep(2)

# bobber.throw()

while True:
    if not is_bobber_found:
        find_bobber()

    data = stream.read(frames)

    # region Record sound
    threshold = 1000
    max_value = 0

    as_ints = array("h", data)
    max_value = max(as_ints)
    if max_value > threshold:
        # print("sound found " + str(sound_length))
        sound_length += 1
        silence_length = 0
    else:
        silence_length += check_interval
        if silence_length >= reset_sound:
            sound_length = 0
    # endregion

    # region Determine if an event ocurred
    if sound_length > 5:
        sound_length = 0
        if is_bobber_found:
            is_bobber_found = False
            print("catch:Fish catched!", flush=True)
            time.sleep(2)
        else:
            print("notfound:Tried to catch fish but bobber is not found.", flush=True)
    elif silence_length >= timeout_length:
        silence_length = 0
        is_bobber_found = 0
        print("timeout:Fishing timed out. Throw another bobber", flush=True)
    # endregion

    time.sleep(check_interval)

print("end:Recording ended.", flush=True)

stream.stop_stream()
stream.close()
audio.terminate()


# endregion Main.py

