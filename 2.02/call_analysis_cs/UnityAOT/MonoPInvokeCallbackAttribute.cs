using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class MonoPInvokeCallbackAttribute : Attribute
{
	public Type type;

	[CallerCount(Count = 101)]
	[DeduplicatedMethod]
	public MonoPInvokeCallbackAttribute(Type t)
	{
	}
}
