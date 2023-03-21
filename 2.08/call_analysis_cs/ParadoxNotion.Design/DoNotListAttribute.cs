using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DoNotListAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DoNotListAttribute()
	{
	}
}
