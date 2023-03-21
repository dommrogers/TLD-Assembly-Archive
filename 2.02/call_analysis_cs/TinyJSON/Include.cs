using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class Include : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Include()
	{
	}
}
