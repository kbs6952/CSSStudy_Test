﻿class Program
{
    // 1강 OT. 
    // 학습 목표: C# 언어의 특징 유니티가 C#을 이용하여 얻는 장점

    #region C# 언어의 특징
    // (1) C# 언어의 특징
    // 1. C# 컴파일러가 C# 언어를 중간언어(IL : intermediate Language)로 컴파일 한다.
    // 2. 중간 언어는 CPU가 바로 해석할 수 있는 것이 아니라 "가상 머신 환경"에서 CPU가 해석할 수 있게 해석해준다.
    // 3. 이러한 구조 덕분에 다양한 플랫폼에서 IL로 컴파일된 코드를 실행할 수 있다. 
    #endregion

    #region AOT 컴파일과 JIT 컴파일
    // (2) AOT 컴파일과 JIT 컴파일 차이에 대한 이해
    // AOT(Ahead of Time) :
    // 장점 : 실행 시점(런타임)에 성능 이슈가
    // 단점 : 실행 전에 전체 파일을 빌드해야 하기 때문에 빌드 속도가 느려진다.

    // JIT(Just In Time) :
    // 장점 : AOT 방식에 비해 빌드 속도가 빠르며, Hot Reload 기능을 제공한다.
    // 단점 : 실행 시점(런타임)에 기계어로 변환시키기 때문에 성능 이슈가 발생한다.
    // Hot Reload : 소스 코드의 변경 사항을 즉시 프로그램에 반영하되, 프로그램의 현재 상태를 유지하는 기능이다.
    // 프로그램에 수정되지 않은 데이터는 그대로 유지하면서 UI나 특정 알고리즘의 변경 사항하여 테스트 가능하다. 
    #endregion

    #region 유니티에서 제공하는 빌드 방식
    // (3) 유니티가 게임을 빌드 하기위한 방식
    // 유니티에서는 MONO빌드와 IL2CPP 두 가지 방식을 제공합니다.

    // MONO 방식은 유니티에서 C#을 IL로 변환하여 JIT 방식으로 프로그램을 빌드하는 방법입니다.
    // 장점 : JIT 컴파일 방식을 채용하므로 컴파일이 빠릅니다. 에디터에서 게임을 즉각적으로 변경사항을 확인할 수 있습니다.
    // 단점 : 런타임에서 성능과 보안 상의 문제가 발생하기 때문에 빌드에서는 사용을 지양한다.

    // IL2CPP 방식은 C#으로 컴파일된 IL 코드를 유니티의 dll을 참조하여 AOT 컴파일 방식으로 c++로 변환해주는 방법입니다.
    // 장점 : C++언어는 NDK(Native Development Kit)환경을 제공하는 안드로이드와 애플(IOS) 기종에서 실행된다.
    // 단점 : C++로 코드가 변환되는 과정을 거치기 때문에 빌드 시간이 더 길어지며, Reflection을 사용하는 클래스에서 에러가 발생한다. 
    #endregion

    static void Main(string[] args)
	{
		
	}
}