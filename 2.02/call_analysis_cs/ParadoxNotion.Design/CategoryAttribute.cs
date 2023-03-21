using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class CategoryAttribute : Attribute
{
	public readonly string category;

	[DeduplicatedMethod]
	[CallerCount(Count = 103)]
	public CategoryAttribute(string category)
	{
	}
}
