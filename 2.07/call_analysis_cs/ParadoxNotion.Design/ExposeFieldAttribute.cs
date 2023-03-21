using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ExposeFieldAttribute : Attribute
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ExposeFieldAttribute()
	{
	}
}
