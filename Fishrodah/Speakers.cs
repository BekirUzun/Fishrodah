using nucs.JsonSettings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishrodah
{
    public class Speakers : JsonSettings
    {
        public override string FileName { get; set; } = "speakers.json";

        public List<SoundDevice> DeviceList { get; set; } = new List<SoundDevice>();

        public Speakers() { }

        public Speakers(string fileName) : base(fileName) { }
    }
}
