using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public interface ITLDConcurrentGraphOwner
{
	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void RegisterConcurrentGraph(string id, GraphOwner graphOwner);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void RemoveConcurrentGraph(string id);
}
