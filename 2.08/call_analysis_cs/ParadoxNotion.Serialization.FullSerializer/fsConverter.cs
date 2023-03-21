using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsConverter : fsBaseConverter
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract bool CanProcess(Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected fsConverter()
	{
	}
}
