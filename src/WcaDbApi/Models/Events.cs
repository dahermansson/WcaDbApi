﻿using System;
using System.Collections.Generic;

namespace WcaDbApi.Models
{
    public partial class Events
    {
        public Events()
        {
            Scrambles = new HashSet<Scrambles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Format { get; set; }
        public string CellName { get; set; }

        public virtual ICollection<Scrambles> Scrambles { get; set; }
    }
}
