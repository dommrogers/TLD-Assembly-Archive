using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class SpoofAOTAttribute : Attribute
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SpoofAOTAttribute()
	{
	}
}
