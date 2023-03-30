using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsIgnoreAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public fsIgnoreAttribute()
	{
	}
}
