using TLD.Gear;

public interface CraftingLocationInterface
{
	CraftingLocation GetLocation();

	int ModifyCraftingTime(int minutes);

	bool ReadyForBlueprint(BlueprintData bp);

	bool ReadyToCraft();

	void ShowError(CraftingLocationError error);
}
