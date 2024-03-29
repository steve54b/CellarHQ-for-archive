﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class WineVarietalPercent
    {
        private int wineID;
        private int varietalID;
        private int varietalPercent;

        public int WineID { get; set; }
        public int VarietalID { get; set; }
        public int VarietalPercent { get; set; }

        public WineVarietalPercent(int WineID, int varietalID, int varietalPercent)
        {
            WineID = wineID;
            VarietalID = varietalID;
            VarietalPercent = varietalPercent;
        }

    }
}
