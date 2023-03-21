public interface CraftingLocationInterface
{
	CraftingLocation GetLocation();

	int ModifyCraftingTime(int minutes);

	bool ReadyForBlueprint(BlueprintItem bpi);

	bool ReadyToCraft();

	void ShowError(CraftingLocationError error);
}
