using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsConverter : fsBaseConverter
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool CanProcess(Type type);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected fsConverter()
	{
	}
}
