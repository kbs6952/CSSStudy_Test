using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    internal class Mutable_Type_and_Immutable_Type
    {
        // 데이터 값 타입 vs 참조 타입
        // 메모리가 작은  타입은 값 타입으로 C#이 놓음 -> int, double, float...
        // 메모리가 상대적 클 것이라고 생각되는 타입들은 참조 타입으로 정해졌다.->class, delegate, string

        // 가변 객체 Mutable Type

        // 불변 객체 Immutable Type

        void Example()
        {
            int num = 3;
            num = 4;

            string a = "AA";
            a = "BB";

            // 스레드 Thread
            // 동기 프로그래밍 비동기 프로그래밍

            void StringTest()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("AA");
                sb.Append("CC");

                Console.WriteLine(sb.ToString());
            }

        }

    }
}
