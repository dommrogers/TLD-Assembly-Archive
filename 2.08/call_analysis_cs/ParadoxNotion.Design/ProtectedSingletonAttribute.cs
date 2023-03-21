using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ProtectedSingletonAttribute : Attribute
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ProtectedSingletonAttribute()
	{
	}
}
