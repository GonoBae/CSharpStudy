using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Test.GoodStarter1
{
    public class Solution
    {
        public string solution(int num)
        {
            string answer = "";
            if (num % 2 == 0) answer = "Even";
            else answer = "Odd";
            return answer;
        }
    }
}
