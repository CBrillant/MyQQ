﻿using Server.Router._Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Router._Response
{
    class MessageResponse : Response
    {

        public string from { get; set; }

        public string to { get; set; }

        public string content { get; set; }

        public DateTime time { get; set; }

        public MessageResponse(MessageRequest message)
        {
            type = "message";
            from = message.from;
            to = message.to;
            content = message.content;
            time = message.time;
        }
    }
}