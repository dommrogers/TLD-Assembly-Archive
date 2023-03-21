using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DoNotListAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DoNotListAttribute()
	{
	}
}
