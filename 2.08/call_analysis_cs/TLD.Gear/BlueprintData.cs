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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetLockedState()
	{
	}

	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	public bool CanCraftAtLocation(CraftingLocation craftingLocation)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool HasRequiredTool(Inventory inventory)
	{
		return false;
	}

	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public List<GearItem> GetToolsAvailableToCraft(Inventory inventory)
	{
		return null;
	}

	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BlueprintData), Member = "GetInProgressItem")]
	[Calls(Type = typeof(BlueprintData), Member = "NumNeedsConsuming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(BlueprintData), Member = "ApplyQuantityMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasRequiredMaterials(Inventory inventory, PlayerManager playerManager)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private InProgressCraftItem GetInProgressItem(Inventory inventory)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public int NumNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public int NumToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public bool IsLocked(bool isStoryMode)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsUnknownMethods(Count = 6)]
	private void AddAlternateTools()
	{
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsUnknownMethods(Count = 1)]
	private float ApplyQuantityMultiplier(float quantityRequired)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BlueprintData()
	{
	}
}
