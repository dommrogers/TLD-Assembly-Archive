using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyString : Variant
{
	private string value;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ProxyString(string value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public override string ToString(IFormatProvider provider)
	{
		return null;
	}
}
