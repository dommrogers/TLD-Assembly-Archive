using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class EnumAsText<T> where T : Enum
{
	private string m_EnumValueAsString;

	private T m_EnumValue;

	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public T GetValue()
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EnumAsText()
	{
	}
}
