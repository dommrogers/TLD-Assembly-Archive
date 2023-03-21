using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomExample : MonoBehaviour
{
	private struct CipherInt
	{
		public int value;

		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		private static void ToJson(StringBuilder sb, object obj)
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FastJson.JsonParser), Member = "ReadUInt32")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static object FromJson(Type type, FastJson.JsonParser parser)
		{
			return null;
		}
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CustomExample()
	{
	}
}
