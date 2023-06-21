using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Cooking;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

public class BlueprintData : ScriptableObject
{
	[Serializable]
	public class RequiredGearItem
	{
		public enum Units
		{
			Count,
			Kilograms
		}

		public GearItem m_Item;

		public int m_Count;

		public float m_Quantity;

		public Units m_Units;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public RequiredGearItem()
		{
		}
	}

	[Serializable]
	public class RequiredPowder
	{
		public PowderType m_Powder;

		public float m_QuantityInKilograms;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public RequiredPowder()
		{
		}
	}

	[Serializable]
	public class RequiredLiquid
	{
		public LiquidType m_Liquid;

		public float m_VolumeInLitres;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public RequiredLiquid()
		{
		}
	}

	public RequiredGearItem[] m_RequiredGear;

	public ToolsItem m_RequiredTool;

	public ToolsItem[] m_OptionalTools;

	public RequiredPowder[] m_RequiredPowder;

	public RequiredLiquid[] m_RequiredLiquid;

	public GearItem m_CraftedResult;

	public AssetReferenceTexture2D m_CraftingIcon;

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
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
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
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCraftingSuccess")]
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
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCookRecipe")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BlueprintData), Member = "GetInProgressItem")]
	[Calls(Type = typeof(BlueprintData), Member = "AmountNeedsConsuming")]
	[Calls(Type = typeof(Inventory), Member = "GetAmountInInventoryInKilograms")]
	[Calls(Type = typeof(BlueprintData), Member = "NumNeedsConsuming")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(Inventory), Member = "GetTotalLiquidVolume")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasRequiredMaterials(Inventory inventory, PlayerManager playerManager)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private float AmountNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return 0f;
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

	[CalledBy(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public int NumToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public float AmountToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool IsLocked(bool isStoryMode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[CallsUnknownMethods(Count = 1)]
	public Texture2D GetCraftingIcon()
	{
		return null;
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

	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCookRecipe")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	[CalledBy(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool HasRequiredTool(Inventory inventory)
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsUnknownMethods(Count = 1)]
	private float ApplyQuantityMultiplier(float quantityRequired)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static int CompareBlueprintDataByName(BlueprintData x, BlueprintData y)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BlueprintData()
	{
	}
}
