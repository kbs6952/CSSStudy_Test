using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    internal class String_Process
    {
        // 문자열 찾기

        // indexOf

        // LastIndexOf

        // StartsWith

        //Contains

        //
            

        // 문자열 변형하기

        // 문자열 분할하기
        // split, substring

        void SS()
        {
            string a = "abcdefg";
            a=a.Substring(1);
            a = a.Substring(2, 4);

            // split

            string[] arr = null;
            string b = "안녕,하세요,반갑,습니다";
            arr = b.Split(',');
        }

        // 문자열 서식 맞추기
    }
}
