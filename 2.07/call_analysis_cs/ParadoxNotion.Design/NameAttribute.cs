using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class NameAttribute : Attribute
{
	public readonly string name;

	public readonly int priority;

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public NameAttribute(string name, int priority = 0)
	{
	}
}
