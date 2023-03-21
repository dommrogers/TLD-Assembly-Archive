using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsConverter : fsBaseConverter
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract bool CanProcess(Type type);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected fsConverter()
	{
	}
}
