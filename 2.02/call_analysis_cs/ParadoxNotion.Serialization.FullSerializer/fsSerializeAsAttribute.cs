using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsSerializeAsAttribute : Attribute
{
	public readonly string Name;

	[CallerCount(Count = 101)]
	[DeduplicatedMethod]
	public fsSerializeAsAttribute(string name)
	{
	}
}
