using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IReflectedWrapper
{
	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	MemberInfo GetMemberInfo();
}
