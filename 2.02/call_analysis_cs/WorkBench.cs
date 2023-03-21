using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WorkBench : MonoBehaviour, CraftingLocationInterface
{
	public LocalizedString m_LocalizedDisplayName;

	public float m_CraftingAndRepairSkillModifier;

	public float m_CraftingAndRepairTimeModifier;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintItem bpi)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyToCraft()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetCraftingLocation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WorkBench()
	{
	}
}
