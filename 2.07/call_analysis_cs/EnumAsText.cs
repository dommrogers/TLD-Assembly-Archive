using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class EnumAsText<T> where T : Enum
{
	private string m_EnumValueAsString;

	private T m_EnumValue;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public T GetValue()
	{
		return (T)null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(T value)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public EnumAsText()
	{
	}
}
