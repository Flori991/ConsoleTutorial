using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerProject
{
    public class Result
    {
        public int result { get; set; }
        public int remain { get; set; }

        public Result(int result, int remain = 0)
        {
            this.result = result;
            this.remain = remain;
        }
    }
}
