using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;

public interface CraftingLocationInterface
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	CraftingLocation GetLocation();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	int ModifyCraftingTime(int minutes);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	bool ReadyForBlueprint(BlueprintData bp);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool ReadyToCraft();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void ShowError(CraftingLocationError error);
}
