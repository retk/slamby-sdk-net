﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierPrepareSettings : ServicePrepareSettings
    {
        [Required]
        public string DataSetName { get; set; }

        [Required]
        public List<string> TagIdList { get; set; }

        [Required]
        public List<int> NGramList { get; set; }


    }
}
