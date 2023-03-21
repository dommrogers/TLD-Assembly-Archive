using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public class Exclude : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Exclude()
	{
	}
}
