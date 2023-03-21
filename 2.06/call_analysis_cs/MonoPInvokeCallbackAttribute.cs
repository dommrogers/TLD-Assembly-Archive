using System;
using Cpp2ILInjected.CallAnalysis;

public class MonoPInvokeCallbackAttribute : Attribute
{
	private Type type;

	[DeduplicatedMethod]
	[CallerCount(Count = 269)]
	public MonoPInvokeCallbackAttribute(Type t)
	{
	}
}
