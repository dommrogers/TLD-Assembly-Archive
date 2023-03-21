using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public class TypeHint : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TypeHint()
	{
	}
}
