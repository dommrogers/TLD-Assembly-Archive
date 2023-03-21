using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsConverter : fsBaseConverter
{
	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	public abstract bool CanProcess(Type type);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected fsConverter()
	{
	}
}
