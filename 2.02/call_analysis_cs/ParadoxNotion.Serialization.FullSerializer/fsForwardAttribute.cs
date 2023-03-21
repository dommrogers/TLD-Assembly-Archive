using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public sealed class fsForwardAttribute : Attribute
{
	public string MemberName;

	[DeduplicatedMethod]
	[CallerCount(Count = 103)]
	public fsForwardAttribute(string memberName)
	{
	}
}
