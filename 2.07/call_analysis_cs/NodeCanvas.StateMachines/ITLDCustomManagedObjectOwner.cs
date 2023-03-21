using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public interface ITLDCustomManagedObjectOwner
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void AddCustomManagedObject(string name, bool reqState);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void RemoveCustomManagedObject(string name);
}
