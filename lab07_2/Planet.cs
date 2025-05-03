using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_2
{
    public enum WarpStatus
    {
        Normal,
        Unstable,
        Storm
    }
    public class Planet
    {
        public Planet() { }
        public Planet(string name, string type, string control, string warp_status, string faction, string unique_feature, int danger_level) 
        {
            Name = name;
            Type = type;
            Control = control;
            WrapStatus = SetWarpStatus(warp_status);
            Faction = faction;
            UniqueFeature = unique_feature;
            DangerLevel = danger_level;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Control { get; set; }
        public WarpStatus WrapStatus { get; set; }
        public string Faction { get; set; }
        public string UniqueFeature { get; set; }
        private int dangerLevel;

        public int DangerLevel
        {
            get { return dangerLevel; }
            set
            {
                if (value < 1)
                {
                    dangerLevel = 1;
                }
                else if (value > 10)
                {
                    dangerLevel = 10;
                }
                else
                {
                    dangerLevel = value;
                }
            }
        }
        private WarpStatus SetWarpStatus(string status)
        {
            switch (status.ToLower())
            {
                case "нестабільний": return WarpStatus.Unstable;
                case "буря": return WarpStatus.Storm;
                default: return WarpStatus.Normal;
            }
        }
    }
}
