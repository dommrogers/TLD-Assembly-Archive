using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class BlueprintItem : MonoBehaviour
{
	public GearItem[] m_RequiredGear;

	public int[] m_RequiredGearUnits;

	public ToolsItem m_RequiredTool;

	public ToolsItem[] m_OptionalTools;

	public GearItem m_CraftedResult;

	public int m_CraftedResultCount;

	public int m_DurationMinutes;

	public string m_CraftingAudio;

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

	private static List<string> m_UnlockedBlueprints;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintItem), Member = "AddAlternateTools")]
	public void Start()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BlueprintItem), Member = "MarkBlueprintUnlocked")]
	[Calls(Type = typeof(BlueprintItem), Member = "ClearUnlockedBlueprints")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 2)]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	public static void ClearUnlockedBlueprints()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsBlueprintUnlocked(string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 3)]
	public string GetDisplayedNameWithCount()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool CanCraftAtLocation(CraftingLocation craftingLocation)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool HasRequiredTool()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public List<GearItem> GetToolsAvailableToCraft()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(BlueprintDisplayItem), Member = "Setup")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BlueprintItem), Member = "HasRequiredTool")]
	public bool CanCraftBlueprint(CraftingLocationInterface cli)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(BlueprintItem), Member = "ApplyQuantityMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintItem), Member = "ApplyQuantityMultiplier")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BlueprintItem), Member = "GetInProgressItem")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(BlueprintItem), Member = "NumNeedsConsuming")]
	public bool HasRequiredMaterials()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	public int NumNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallsUnknownMethods(Count = 7)]
	public int NumToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return default(int);
	}

	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void MaybeRemoveStoryTools()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLocked(bool isStoryMode)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 4)]
	public void UnlockSilent()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	public void UnlockWithNotification()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private InProgressCraftItem GetInProgressItem(BlueprintItem bpi)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "Start")]
	[CallsUnknownMethods(Count = 43)]
	private void AddAlternateTools()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "FindBlueprintsForGear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void MarkBlueprintUnlocked(string craftedResultName)
	{
	}

	[CallerCount(Count = 0)]
	private SubCategory MapCategories(GearTypeEnum gearTypeEnum)
	{
		return default(SubCategory);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CallsUnknownMethods(Count = 3)]
	private float ApplyQuantityMultiplier(float quantityRequired)
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public BlueprintItem()
	{
	}
}
