using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.Common;
using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace NetIM.Server
{
    public class MessageReceiveFilter : ReceiveFilterBase<BinaryRequestInfo>
    {
        public MessageReceiveFilter()
        {

        }

        public override  BinaryRequestInfo Filter(byte[] readBuffer, int offset, int length, bool toBeCopied, out int rest)
        {
            BinaryRequestInfo bri = new BinaryRequestInfo("", readBuffer.Skip(offset).Take(length).ToArray());
            rest = 0;
            return bri;
        }
    }
}
