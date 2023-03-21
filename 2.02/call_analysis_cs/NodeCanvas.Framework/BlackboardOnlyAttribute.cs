using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class BlackboardOnlyAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BlackboardOnlyAttribute()
	{
	}
}
