using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public interface ITLDConcurrentGraphOwner
{
	void RegisterConcurrentGraph(string id, GraphOwner graphOwner);

	void RemoveConcurrentGraph(string id);
}
