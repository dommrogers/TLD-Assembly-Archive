using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class SpoofAOTAttribute : Attribute
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SpoofAOTAttribute()
	{
	}
}
