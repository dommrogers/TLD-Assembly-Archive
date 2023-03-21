using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public interface ITLDCustomManagedObjectOwner
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void AddCustomManagedObject(string name, bool reqState);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void RemoveCustomManagedObject(string name);
}
