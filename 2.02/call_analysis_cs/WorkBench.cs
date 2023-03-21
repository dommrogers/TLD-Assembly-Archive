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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public int ModifyCraftingTime(int minutes)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintItem bpi)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyToCraft()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetCraftingLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WorkBench()
	{
	}
}
