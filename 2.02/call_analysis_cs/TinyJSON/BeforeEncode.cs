using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public class BeforeEncode : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BeforeEncode()
	{
	}
}
