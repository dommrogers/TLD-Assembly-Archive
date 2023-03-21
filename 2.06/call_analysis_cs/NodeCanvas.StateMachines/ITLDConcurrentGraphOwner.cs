using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public interface ITLDConcurrentGraphOwner
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void RegisterConcurrentGraph(string id, GraphOwner graphOwner);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void RemoveConcurrentGraph(string id);
}
