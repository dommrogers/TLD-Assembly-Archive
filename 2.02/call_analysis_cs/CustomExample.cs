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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(TypeFullName = "System.Number", Member = "FormatUInt32")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private static void ToJson(StringBuilder sb, object obj)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FastJson.JsonParser), Member = "ReadUInt32")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static object FromJson(Type type, FastJson.JsonParser parser)
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(FastJson), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CustomExample()
	{
	}
}
