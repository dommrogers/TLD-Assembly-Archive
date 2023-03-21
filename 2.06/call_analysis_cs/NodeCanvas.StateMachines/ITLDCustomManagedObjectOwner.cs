namespace NodeCanvas.StateMachines;

public interface ITLDCustomManagedObjectOwner
{
	void AddCustomManagedObject(string name, bool reqState);

	void RemoveCustomManagedObject(string name);
}
