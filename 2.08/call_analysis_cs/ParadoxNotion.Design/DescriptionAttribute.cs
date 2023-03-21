using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DescriptionAttribute : Attribute
{
	public readonly string description;

	[CallerCount(Count = 279)]
	[DeduplicatedMethod]
	public DescriptionAttribute(string description)
	{
	}
}
