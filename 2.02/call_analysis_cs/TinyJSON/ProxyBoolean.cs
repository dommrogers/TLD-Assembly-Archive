using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyBoolean : Variant
{
	private bool value;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ProxyBoolean(bool value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override bool ToBoolean(IFormatProvider provider)
	{
		return false;
	}
}
