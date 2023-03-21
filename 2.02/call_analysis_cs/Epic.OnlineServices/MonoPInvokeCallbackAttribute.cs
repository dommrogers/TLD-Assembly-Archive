using System;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal sealed class MonoPInvokeCallbackAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MonoPInvokeCallbackAttribute(Type type)
	{
	}
}
