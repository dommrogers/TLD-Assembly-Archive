using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public interface ISettable
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Set(object other);
}
