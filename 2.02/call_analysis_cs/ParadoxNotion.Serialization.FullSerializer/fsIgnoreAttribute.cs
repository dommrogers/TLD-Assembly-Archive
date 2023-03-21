using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsIgnoreAttribute : Attribute
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public fsIgnoreAttribute()
	{
	}
}
