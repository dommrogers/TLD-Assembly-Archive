using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;

public interface CraftingLocationInterface
{
	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	CraftingLocation GetLocation();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	int ModifyCraftingTime(int minutes);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool ReadyForBlueprint(BlueprintData bp);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool ReadyToCraft();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void ShowError(CraftingLocationError error);
}
