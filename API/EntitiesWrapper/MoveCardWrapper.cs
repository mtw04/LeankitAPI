﻿using Leankit.Entities;
using System.Collections.Generic;

namespace Leankit.EntitiesWrapper
{
    public class MoveCardWrapper
    {
        public string ReplyCode { get; set; }
        public string ReplyText { get; set; }
        public List<string> ReplyData { get; set; } //contains BoardVersion
    }
}
