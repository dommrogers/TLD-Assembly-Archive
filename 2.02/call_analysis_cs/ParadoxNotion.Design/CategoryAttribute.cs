using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class CategoryAttribute : Attribute
{
	public readonly string category;

	[CallerCount(Count = 101)]
	[DeduplicatedMethod]
	public CategoryAttribute(string category)
	{
	}
}
