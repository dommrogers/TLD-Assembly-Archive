using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ExposeAsDefinitionAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ExposeAsDefinitionAttribute()
	{
	}
}
