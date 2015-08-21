using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.ClientEngine;
using SuperSocket.ClientEngine.Protocol;
using SuperSocket.ClientEngine.Proxy;
using System.Net;
using System.Net.Sockets;
using NetIM.Models;

namespace NetIM.Client
{
    public class IMClient : AsyncTcpSession 
    {
        public IMClient(EndPoint remoteEndPoint)
            :base(remoteEndPoint)
        {
            
        }

        public void SendTextMessage(string text)
        {
            Message msg = new Message();
            msg.GUID = Guid.NewGuid().ToString();
            msg.message = text;
            byte[] bytes = MessageHelper.getBytes(msg);
            this.Send(bytes,0,bytes.Length);
        }

    }
}
