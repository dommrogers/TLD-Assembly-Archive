using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ExampleNS;

public class Example : MonoBehaviour
{
	private class ExampleClass
	{
		public int id;

		public string name;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ExampleClass()
		{
		}
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Example), Member = "ToString")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[Calls(Type = typeof(FastJson), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Example), Member = "ToString")]
	[CalledBy(Type = typeof(Example), Member = "Start")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Example), Member = "ToString")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	private string ToString(object a)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Example()
	{
	}
}
