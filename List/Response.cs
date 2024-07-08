using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Response<TData>
    {
        public bool Status { get; set; }
        public string Msg { get; set; }
        public TData Data { get; set; }
    }
}
