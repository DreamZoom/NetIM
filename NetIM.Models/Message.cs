using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIM.Models
{

    [Serializable] 
    public class Message
    {
        public string GUID { get; set; }

        public string message { get; set; }


    }
}
