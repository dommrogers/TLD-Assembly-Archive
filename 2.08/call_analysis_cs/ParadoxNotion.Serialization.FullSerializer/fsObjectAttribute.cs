using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsObjectAttribute : Attribute
{
	public Type Converter;

	public Type Processor;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public fsObjectAttribute()
	{
	}
}
