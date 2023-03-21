using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class BlueprintData : ScriptableObject
{
	[Serializable]
	public class RequiredGearItem
	{
		public GearItem m_Item;

		public int m_Count;

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public RequiredGearItem()
		{
		}
	}

	public RequiredGearItem[] m_RequiredGear;

	public ToolsItem m_RequiredTool;

	public ToolsItem[] m_OptionalTools;

	public GearItem m_CraftedResult;

	public int m_CraftedResultCount;

	public int m_DurationMinutes;

	public AK.Wwise.Event m_CraftingAudio;

	public float m_KeroseneLitersRequired;

	public float m_GunpowderKGRequired;

	public bool m_RequiresLight;

	public bool m_Locked;

	public bool m_IgnoreLockInSurvival;

	public bool m_AppearsInStoryOnly;

	public bool m_AppearsInSurvivalOnly;

	public SkillType m_AppliedSkill;

	public SkillType m_ImprovedSkill;

	public CraftingLocation m_RequiredCraftingLocation;

	public bool m_RequiresLitFire;

	public bool m_CanIncreaseRepairSkill;

	private bool _003CLocked_003Ek__BackingField;

	private GameObject m_proxy;

	public bool Locked
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Transform transform
	{
		[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
		[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
		[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(BlueprintData), Member = "AddAlternateTools")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetLockedState()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	public string GetDisplayedNameWithCount()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanCraftBlueprint(Inventory inventory, PlayerManager playerManager, CraftingLocationInterface cli)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CanCraftAtLocation(CraftingLocation craftingLocation)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	private bool HasRequiredTool(Inventory inventory)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	public List<GearItem> GetToolsAvailableToCraft(Inventory inventory)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(BlueprintData), Member = "ApplyQuantityMultiplier")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(BlueprintData), Member = "ApplyQuantityMultiplier")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BlueprintData), Member = "GetInProgressItem")]
	[Calls(Type = typeof(BlueprintData), Member = "NumNeedsConsuming")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HasRequiredMaterials(Inventory inventory, PlayerManager playerManager)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private InProgressCraftItem GetInProgressItem(Inventory inventory)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallsUnknownMethods(Count = 3)]
	public int NumNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public int NumToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public bool IsLocked(bool isStoryMode)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BlueprintData), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 6)]
	private void AddAlternateTools()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private float ApplyQuantityMultiplier(float quantityRequired)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BlueprintData()
	{
	}
}
