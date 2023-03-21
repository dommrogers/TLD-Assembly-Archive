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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ExampleClass()
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(FastJson), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FastJson), Member = "Deserialize")]
	[Calls(Type = typeof(Example), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 59)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Example), Member = "Start")]
	[CalledBy(Type = typeof(Example), Member = "ToString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Example), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
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
