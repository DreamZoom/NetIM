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


namespace NetIM.Client
{
    public class IMClient : AsyncTcpSession 
    {
        public IMClient(EndPoint remoteEndPoint)
            :base(remoteEndPoint)
        {
            
        }

    }
}
