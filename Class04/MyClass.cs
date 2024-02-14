using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04
{
    // 1. 클래스의 기본 문법
    // 속성과 함수(메소드)

    // 2. 클래스 생성
    // 기본 문법
    // 클래스명 호출할 이름(인스턴스) = new 클래스명();
    // MyClass myClass = new MyClass();

    // 3. struct와 class의 차이
    // 상속
     class MyClass
    {
        // 접근지정자 데이터 타입 이름;
        private int field_01;
        private int field_02;
        public int field_03;

        public void CallField(int value)
        {
            field_01 = value;
        }
        public int ReturnField(int value)
        {
            return field_01;
        }
        public MyClass()
        {

        }

        // 메소드 오버로딩
        public MyClass(int  field_03)
        {
            this.field_03= field_03;
        }

        #region 접근지정자
        // 접근지정자
        // private, public, protected, internal protected, internal public
        // 접근 지정자가 뭐냐?
        // 클래스 내부의 포함되어 있는 속성에 접근 범위를 제한하는 지정자입니다.

        // protected. 클래스는 다른 클래스를 상속 받을 수 있습니다.

        // internal
        // 같은 어셈블리 내에서 public같은 효과를 갖고, 다른 어셈블리에서는 private 적용되는 접근 지정자.

        // 어셈블리 : 컴파일을 통해 만들어진 파일 C#에서 부르는 말.
        // .exe - : Main메소드가 포함된 클래스는 .exe
        // .dll - : 그 이외의 다른 클래스들이 라이브러리 형태로 저장이 된다.

        // Library - FrameWork
        #endregion
    }

    

}
