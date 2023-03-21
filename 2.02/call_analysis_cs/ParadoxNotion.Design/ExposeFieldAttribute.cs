using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ExposeFieldAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ExposeFieldAttribute()
	{
	}
}
