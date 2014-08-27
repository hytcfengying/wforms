using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ChatDemo
{
    public class Friend
    {
        public Friend friend { get; set; }

        public string nickName { get; set; }

        public string shuoshuo { get; set; }

        public IPAddress IP { get; set; }

        public int imageIndex { get; set; }

        public bool isopen { get; set; }

        public FormChat formchat { get; set; }

    }
}
