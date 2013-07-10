﻿using Leankit.Entities;
using System.Collections.Generic;

namespace Leankit.EntitiesWrapper
{
    public class UpdateCardWrapper
    {
        public string ReplyCode { get; set; }
        public string ReplyText { get; set; }
        public List<UpdateCardReplyData> ReplyData { get; set; }
    }
}
