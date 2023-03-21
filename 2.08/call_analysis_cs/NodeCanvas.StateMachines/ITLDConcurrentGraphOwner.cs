using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public interface ITLDConcurrentGraphOwner
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void RegisterConcurrentGraph(string id, GraphOwner graphOwner);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void RemoveConcurrentGraph(string id);
}
