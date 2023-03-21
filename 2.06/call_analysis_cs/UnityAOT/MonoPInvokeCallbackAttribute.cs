using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class MonoPInvokeCallbackAttribute : Attribute
{
	public Type type;

	[DeduplicatedMethod]
	[CallerCount(Count = 265)]
	public MonoPInvokeCallbackAttribute(Type t)
	{
	}
}
