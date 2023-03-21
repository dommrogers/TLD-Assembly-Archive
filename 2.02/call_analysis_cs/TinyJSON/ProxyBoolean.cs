using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyBoolean : Variant
{
	private bool value;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ProxyBoolean(bool value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public override bool ToBoolean(IFormatProvider provider)
	{
		return default(bool);
	}
}
