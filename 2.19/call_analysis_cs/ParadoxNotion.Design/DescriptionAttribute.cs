using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DescriptionAttribute : Attribute
{
	public readonly string description;

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public DescriptionAttribute(string description)
	{
	}
}
