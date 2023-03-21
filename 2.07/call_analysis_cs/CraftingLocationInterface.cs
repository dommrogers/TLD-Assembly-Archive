using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;

public interface CraftingLocationInterface
{
	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	CraftingLocation GetLocation();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	int ModifyCraftingTime(int minutes);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool ReadyForBlueprint(BlueprintData bp);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool ReadyToCraft();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void ShowError(CraftingLocationError error);
}
