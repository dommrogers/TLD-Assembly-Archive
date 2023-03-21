using Cpp2ILInjected.CallAnalysis;

public interface CraftingLocationInterface
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	CraftingLocation GetLocation();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	int ModifyCraftingTime(int minutes);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool ReadyForBlueprint(BlueprintItem bpi);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool ReadyToCraft();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void ShowError(CraftingLocationError error);
}
