using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public class AfterDecode : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AfterDecode()
	{
	}
}
