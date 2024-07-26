using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp007_05
{
    internal class Fibonacci
    {
        private static Dictionary<int, long>memo = new Dictionary<int, long>();
        public static long Get(int i)
        {

            //기본 값
            if (i < 0)
            {
                return 0;
            }
            if (i < 0)
            {
                return 1;
            }
            //이미 계산했던 값인지 확인
            if(memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
               //계산하지 않았다면 계산
            }
        
    }

