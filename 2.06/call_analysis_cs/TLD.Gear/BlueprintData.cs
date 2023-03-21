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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
		[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintData), Member = "AddAlternateTools")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetLockedState()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetDisplayedNameWithCount()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	public bool CanCraftBlueprint(Inventory inventory, PlayerManager playerManager, CraftingLocationInterface cli)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CanCraftAtLocation(CraftingLocation craftingLocation)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool HasRequiredTool(Inventory inventory)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public List<GearItem> GetToolsAvailableToCraft(Inventory inventory)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(BlueprintData), Member = "ApplyQuantityMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintData), Member = "ApplyQuantityMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BlueprintData), Member = "NumNeedsConsuming")]
	[Calls(Type = typeof(BlueprintData), Member = "GetInProgressItem")]
	[CallerCount(Count = 1)]
	public bool HasRequiredMaterials(Inventory inventory, PlayerManager playerManager)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private InProgressCraftItem GetInProgressItem(Inventory inventory)
	{
		return null;
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int NumNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BlueprintData), Member = "OnEnable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallsUnknownMethods(Count = 1)]
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
