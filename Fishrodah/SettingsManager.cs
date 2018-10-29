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
    public class SettingsManager : JsonSettings
    {
        public override string FileName { get; set; } = "settings.json";

        public Keys FishingKey { get; set; }

        public int SelectedSpeaker { get; set; } = -1;

        public SettingsManager() { }

        public SettingsManager(string fileName) : base(fileName) { }
    }
}
