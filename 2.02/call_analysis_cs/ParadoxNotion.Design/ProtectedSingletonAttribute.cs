using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ProtectedSingletonAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ProtectedSingletonAttribute()
	{
	}
}
