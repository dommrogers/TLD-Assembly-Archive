using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IReflectedWrapper
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	MemberInfo GetMemberInfo();
}
