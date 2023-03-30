using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class SpoofAOTAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SpoofAOTAttribute()
	{
	}
}
