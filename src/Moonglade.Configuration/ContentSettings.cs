﻿using System;
using System.Collections.Generic;
using System.Text;
using Moonglade.Configuration.Abstraction;

namespace Moonglade.Configuration
{
    public class ContentSettings : MoongladeSettings
    {
        public string DisharmonyWords { get; set; }

        public bool EnableComments { get; set; }

        public bool EnableWordFilter { get; set; }

        public bool UseFriendlyNotFoundImage { get; set; }

        public int PostListPageSize { get; set; }

        public int HotTagAmount { get; set; }

        public ContentSettings()
        {
            DisharmonyWords = string.Empty;
            EnableComments = true;
            UseFriendlyNotFoundImage = true;
            PostListPageSize = 10;
            HotTagAmount = 10;
        }
    }
}
