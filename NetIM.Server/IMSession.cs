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
    public class IMSession : AppSession<IMSession,BinaryRequestInfo>
    {
        protected override void HandleUnknownRequest(BinaryRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
        }

        protected override void OnSessionStarted()
        {
            this.Charset = Encoding.UTF8;
            this.Send("hello");
            base.OnSessionStarted();
        }
        
    }
}
