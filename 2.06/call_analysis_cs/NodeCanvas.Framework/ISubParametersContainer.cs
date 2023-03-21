using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface ISubParametersContainer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	BBParameter[] GetSubParameters();
}
