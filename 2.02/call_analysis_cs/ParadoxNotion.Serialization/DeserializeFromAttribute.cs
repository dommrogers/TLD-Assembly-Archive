using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

public class DeserializeFromAttribute : Attribute
{
	public readonly string[] previousTypeFullNames;

	[DeduplicatedMethod]
	[CallerCount(Count = 103)]
	public DeserializeFromAttribute(string[] previousTypeNames)
	{
	}
}
