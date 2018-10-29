using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishrodah
{
    public class SoundDevice
    {
        public int Index;
        public int StructVersion;
        public string Name;
        public int HostApi;
        public int MaxInputChannels;
        public int MaxOutputChannels;
        public float DefaultLowInputLatency;
        public float DefaultLowOutputLatency;
        public float DefaultHighInputLatency;
        public float DefaultHighOutputLatency;
        public float DefaultSampleRate;

    }
}
