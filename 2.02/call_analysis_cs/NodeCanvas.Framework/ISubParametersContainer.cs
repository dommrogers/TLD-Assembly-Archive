using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ISubParametersContainer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	BBParameter[] GetSubParameters();
}
