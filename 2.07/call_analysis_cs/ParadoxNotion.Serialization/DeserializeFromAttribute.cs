using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

public class DeserializeFromAttribute : Attribute
{
	public readonly string[] previousTypeFullNames;

	[CallerCount(Count = 279)]
	[DeduplicatedMethod]
	public DeserializeFromAttribute(string[] previousTypeNames)
	{
	}
}
