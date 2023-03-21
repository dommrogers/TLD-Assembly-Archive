using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class EnumAsText<T> where T : Enum
{
	private string m_EnumValueAsString;

	private T m_EnumValue;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsUnknownMethods(Count = 4)]
	public T GetValue()
	{
		return (T)null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetValue(T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EnumAsText()
	{
	}
}
