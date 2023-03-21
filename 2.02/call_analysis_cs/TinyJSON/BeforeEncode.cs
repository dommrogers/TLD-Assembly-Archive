using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public class BeforeEncode : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BeforeEncode()
	{
	}
}
