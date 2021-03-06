﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNR_Manager.Business.Models
{
    public class MeterRemoveDetailsModel
    {
        public bool availability { get; set; }
        public int LetterStatus { get; set; }
        public int OrderCardStatus { get; set; }
        public int MeterRemovedStatus { get; set; }
        public string ReaderCode { get; set; }
        public string DailyPackNo { get; set; }
        public string WalkSeq { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int connectionStats { get; set; }
    }
}
