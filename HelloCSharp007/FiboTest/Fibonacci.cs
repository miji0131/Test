using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fibonacci 수열이란?
//F(0) = 0
//F(1) = 1
//F(n) = F(n - 1) + F(n - 2)(단, n ≥ 2)


namespace FiboTest
{
    public class Fibonacci
    {
       //이전에 계산한 결과를 저장하여 성능을 개선하는 메모이제이션 기법
       //메모이제이션: 동일한 계산을 반복해야 할 때,
       //이전에 계산한 값을 메모리에 저장함으로써 계산 속도를 빠르게 하는 기법
        private static Dictionary<int, long>memo = new Dictionary<int, long>();
        
        // Get메서드: 인자로 주어진 i에 대한 피보나치수를 계산함
        public static long Get(int i)
        {
            //기본 값
            if (i < 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }

            //이미 계산했던 값인지 확인
            //중복을 걸러줌
            if(memo.ContainsKey(i)) 
            {
                return memo[i];
            }
            else
            {
                //계산하지 않았다면 계산
                long value = Get(i -2) + Get(i -1);
                memo[i] = value;
                return value;
            }
        }
    }
}
