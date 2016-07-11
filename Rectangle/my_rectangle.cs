using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class my_rectangle
    {
        const Double default_len = 10.0; //默认长
        const Double default_wid = 5.0;  //默认宽
        public Double length;
        public Double width;
        
        public my_rectangle(Double len = default_len, Double wid = default_wid)
        {
            length = len;
            width = wid;
        }

        public Double getArea()
        {
            return length * width;
        }
    }
}
