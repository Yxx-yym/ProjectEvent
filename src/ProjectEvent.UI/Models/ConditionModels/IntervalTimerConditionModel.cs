﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEvent.UI.Models.ConditionModels
{
    public class IntervalTimerConditionModel : UINotifyPropertyChanged
    {
        private string Second_ = "60";
        public string Second
        {
            get { return Second_; }
            set { Second_ = value; OnPropertyChanged(); }
        }

        private string Num_ = "1";
        public string Num
        {
            get { return Num_; }
            set { Num_ = value; OnPropertyChanged(); }
        }

    }
}
