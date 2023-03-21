using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsConverter : fsBaseConverter
{
	public abstract bool CanProcess(Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected fsConverter()
	{
	}
}
