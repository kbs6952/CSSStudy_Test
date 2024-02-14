namespace Class04
{
    // 4강
    // 날짜 : 2024.02.14
    // 학습 목표 : 클래스의 생성 및 기본 개념 학습

    // 클래스
    // 사용자 정의 데이터 자료형이라고 부른다.
    // 속성과 함수(메소드)가 포함되어 있으며, 클래스는 객체를 생성해서 접근하고 사용할 수 있는 집합체다.

    // 객체 복사
    // 객체 복사하기 : 얕은 복사와 깊은 복사
    // 깊은 복사 : 객체를 메모리 주소를 새로 만들어서 거기에 똑같은 데이터를 복사해서 사용하고 싶다.
    // static 한정자
    // instance 반대되는 개념이라고 생각하면 쉬움
    
    class A
    {
        public A()
        {
            Console.WriteLine("A가 생성되었습니다");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B가 생성되었습니다");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("C가 생성되었습니다");
        }
    }
    
    class Test
    {
        public static int field_3;

        public int field_1;
        public int field_2;

        public static void ShowMassage()
        {
            Console.WriteLine("Static 한정자를 사용한 메소드");
        }
        public void AddField()
        {
            field_3++;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            Test test1 = new Test();
            test1.field_1 = 10;
            test1.field_2 = 20;

            Test test2 = test1;
            test2.field_2 = 30;

            Console.WriteLine($"test1의 field1의 값 : {test1.field_1}");
            Console.WriteLine($"test1의 field2의 값 : {test1.field_2}");

            Console.WriteLine($"test2의 field1의 값 : {test2.field_1}");
            Console.WriteLine($"test2의 field2의 값 : {test2.field_2}");

            // static 사용법
            Test.field_3 = 10;
            Test.ShowMassage();


        }
    }
}
