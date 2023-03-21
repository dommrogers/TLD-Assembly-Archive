using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class BlackboardOnlyAttribute : Attribute
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BlackboardOnlyAttribute()
	{
	}
}
