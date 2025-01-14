﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QQ.Entity
{
    public class MessageBase
    {
        public string ID { get; set; } // 消息ID
        public string fromAccount { get; set; } // 该消息谁发送的
        public string name { get; set; } // 发送者姓名
        public string header { get; set; }
        public string time { get; set; }
        public bool isMy { get; set; } // 是不是我发送的消息，是我发送的，则在右边显示

        public int width { get; set; }

        private DateTime sendTime;

        public DateTime SendTime
        {
            get { return sendTime; }
            set { sendTime = value; time = value.ToString("G"); }
        }

    }
}
