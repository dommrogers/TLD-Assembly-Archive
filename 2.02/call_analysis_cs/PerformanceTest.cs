using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PerformanceTest : MonoBehaviour
{
	private class IntClass
	{
		public int value;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public IntClass()
		{
		}
	}

	private class FloatClass
	{
		public float value;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public FloatClass()
		{
		}
	}

	private class BoolClass
	{
		public bool value;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public BoolClass()
		{
		}
	}

	private class Vector3Class
	{
		public Vector3 value;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector3Class()
		{
		}
	}

	private class StringClass
	{
		public string value;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public StringClass()
		{
		}
	}

	private class ClassAClass
	{
		public ClassA value;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ClassAClass()
		{
		}
	}

	private class EnumClass
	{
		public EnumA value;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public EnumClass()
		{
		}
	}

	private delegate T GenerateFunc<T>();

	private class ArrayClass<T>
	{
		public T[] array;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ArrayClass()
		{
		}
	}

	private enum EnumA
	{
		ABC,
		DEF,
		GHI,
		JKLMN,
		OPQRST,
		UVWXWZ
	}

	private class ClassA
	{
		public int intValueA;

		public int intValueB;

		public bool boolValue;

		public string stringValueA;

		public string stringValueB;

		public float floatValue;

		public List<string> stringList;

		public List<int> intList;

		[CalledBy(TypeFullName = "PerformanceTest.<>c", Member = "<TestPerformance>b__2_6")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PerformanceTest), Member = "GenerateRandomText")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 40)]
		public static ClassA Generate()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ClassA()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static GenerateFunc<int> _003C_003E9__2_0;

		public static GenerateFunc<float> _003C_003E9__2_1;

		public static GenerateFunc<bool> _003C_003E9__2_2;

		public static GenerateFunc<Vector3> _003C_003E9__2_3;

		public static GenerateFunc<string> _003C_003E9__2_4;

		public static GenerateFunc<EnumA> _003C_003E9__2_5;

		public static GenerateFunc<ClassA> _003C_003E9__2_6;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CTestPerformance_003Eb__2_0()
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		internal float _003CTestPerformance_003Eb__2_1()
		{
			return 0f;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CTestPerformance_003Eb__2_2()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		internal Vector3 _003CTestPerformance_003Eb__2_3()
		{
			return default(Vector3);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PerformanceTest), Member = "GenerateRandomText")]
		internal string _003CTestPerformance_003Eb__2_4()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal EnumA _003CTestPerformance_003Eb__2_5()
		{
			return default(EnumA);
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "PerformanceTest.ClassA", Member = "Generate")]
		internal ClassA _003CTestPerformance_003Eb__2_6()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0<T, U> where T : new()
	{
		public T obj;

		public string fastJsonText;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FastJson), Member = "Serialize")]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CTest1_003Eb__0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal void _003CTest1_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0<T>
	{
		public ArrayClass<T> obj;

		public string fastJsonText;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FastJson), Member = "Serialize")]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CTest2_003Eb__0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal void _003CTest2_003Eb__1()
		{
		}
	}

	private StringBuilder resultText;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(PerformanceTest), Member = "TestPerformance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void OnGUI()
	{
	}

	[CalledBy(Type = typeof(PerformanceTest), Member = "OnGUI")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PerformanceTest), Member = "Test1")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 51)]
	private void TestPerformance()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private T GenerateTestData2<T, U>(GenerateFunc<U> generateValue) where T : new()
	{
		return default(T);
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PerformanceTest), Member = "TestPerformance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PerformanceTest), Member = "Stopwatch")]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	private void Test1<T, U>(string name, GenerateFunc<U> generate) where T : new()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private ArrayClass<T> GenerateTestData2<T>(int count, GenerateFunc<T> generate)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PerformanceTest), Member = "Stopwatch")]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	private void Test2<T>(string name, GenerateFunc<T> generate)
	{
	}

	[CalledBy(Type = typeof(PerformanceTest), Member = "Test1")]
	[CalledBy(Type = typeof(PerformanceTest), Member = "Test2")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt64")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Stopwatch(string text, Action action)
	{
	}

	[CalledBy(Type = typeof(ClassA), Member = "Generate")]
	[CalledBy(Type = typeof(_003C_003Ec), Member = "<TestPerformance>b__2_4")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private static string GenerateRandomText(int length)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public PerformanceTest()
	{
	}
}
