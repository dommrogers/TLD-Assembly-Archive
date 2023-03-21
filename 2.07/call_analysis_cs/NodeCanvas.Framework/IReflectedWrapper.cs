using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IReflectedWrapper
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	MemberInfo GetMemberInfo();
}
