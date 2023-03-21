using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomExample2 : MonoBehaviour
{
	private struct CipherInt
	{
		public int value;

		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[CallerCount(Count = 0)]
		public static void Serialize(StringBuilder sb, object obj)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FastJson.JsonParser), Member = "ReadUInt32")]
		[CallsUnknownMethods(Count = 1)]
		public static object Deserialize(Type type, FastJson.JsonParser parser)
		{
			return null;
		}
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CustomExample2()
	{
	}
}
