using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace NetIM.Server
{
    public class IMServer : AppServer<IMSession, BinaryRequestInfo>
    {
        public IMServer()
            : base(new DefaultReceiveFilterFactory<MessageReceiveFilter, BinaryRequestInfo>())
        {
            this.NewRequestReceived += IMServer_NewRequestReceived;
            
        }

        void IMServer_NewRequestReceived(IMSession session, BinaryRequestInfo requestInfo)
        {

            var d = requestInfo.Body;
            string s = Encoding.UTF8.GetString(d);
            session.Send(s);
        }

      
    }
}
