using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsSerializeAsAttribute : Attribute
{
	public readonly string Name;

	[DeduplicatedMethod]
	[CallerCount(Count = 265)]
	public fsSerializeAsAttribute(string name)
	{
	}
}
