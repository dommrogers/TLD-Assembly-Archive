using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ISubParametersContainer
{
	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	BBParameter[] GetSubParameters();
}
