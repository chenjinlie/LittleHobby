using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Littlehobby.Model
{
    public class MsgTemplate
    {
        //SenderID发送者ID
        
        //ReceiverID 接受者ID
        
        //MessageType 消息类型 Text  Voice 等等
        
        //Content 消息内容
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
    }
}
