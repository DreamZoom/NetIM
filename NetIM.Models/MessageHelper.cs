using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace NetIM.Models
{
    public class MessageHelper
    {
        public static byte[] getBytes(Message message)
        {
           using( MemoryStream mem = new MemoryStream(1024)){
                BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
                binFormat.Serialize(mem, message);
                return mem.GetBuffer();
           }
           
        }

        public static Message getMessage(byte[] bytes)
        {
             using( MemoryStream mem = new MemoryStream(1024)){
                 mem.Write(bytes, 0, bytes.Length);
                 BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
                 var msg =  binFormat.Deserialize(mem) as Message;
                 return msg;
            }
        }
    }
}
