using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsForwardAttribute : Attribute
{
	public string MemberName;

	[CallerCount(Count = 265)]
	[DeduplicatedMethod]
	public fsForwardAttribute(string memberName)
	{
	}
}
