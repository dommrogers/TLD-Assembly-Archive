using System;
using Cpp2ILInjected.CallAnalysis;

public class MonoPInvokeCallbackAttribute : Attribute
{
	private Type type;

	[DeduplicatedMethod]
	[CallerCount(Count = 103)]
	public MonoPInvokeCallbackAttribute(Type t)
	{
	}
}
