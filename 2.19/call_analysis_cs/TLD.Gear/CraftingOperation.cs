using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gear;

public class CraftingOperation
{
	private float _003CSkillIncreaseChanceOnSuccess_003Ek__BackingField;

	private float _003CSkillIncreaseChanceOnFailure_003Ek__BackingField;

	private bool _003CInProgress_003Ek__BackingField;

	private BlueprintData _003CBlueprint_003Ek__BackingField;

	private PanelReference<Panel_HUD> m_HUD;

	private MonoBehaviour m_Context;

	private CraftingLocationInterface m_Location;

	private InProgressCraftItem m_WorkInProgress;

	private float m_StoredDayLengthScale;

	private float m_RealTimeDuration;

	private float m_RealTimeElapsed;

	private float m_HoursToSpendCrafting;

	private int m_TargetQuantity;

	private int m_UnitsCompleted;

	private float m_NextUnitProgress;

	private GearItem m_LastCraftedItem;

	private GearItem m_Tool;

	private uint m_AudioID;

	public float SkillIncreaseChanceOnSuccess
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float SkillIncreaseChanceOnFailure
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool InProgress
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
		private set
		{
		}
	}

	public BlueprintData Blueprint
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 57)]
		private set
		{
		}
	}

	public InProgressCraftItem CurrentWorkInProgress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
	}

	public GearItem LastCraftedItem
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public event Action<CraftingInterruptReason> Interrupted
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDestroy")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "OnDestroy")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action Success
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDestroy")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "OnDestroy")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action End
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDestroy")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "OnDestroy")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCookRecipe")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void StartCrafting(MonoBehaviour context, CraftingLocationInterface craftingLocation, BlueprintData blueprintData, InProgressCraftItem workInProgress, float realTimeCraftingDuration, float hoursToSpendCrafting, GearItem tool, int targetQuantity = 1)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	public void Interrupt(CraftingInterruptReason reason)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(CraftingOperation), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(CraftingOperation), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleSuccess")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCancelRecipePreparation")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnCancelCrafting")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "Interrupt")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "Update")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(CraftingOperation), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(CraftingOperation), Member = "UpdateSkillAfterCrafting")]
	[Calls(Type = typeof(CraftingOperation), Member = "DegradeTools")]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleEnd")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleSuccess")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleInterrupt(CraftingInterruptReason reason)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(CraftingOperation), Member = "Update")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallerCount(Count = 2)]
	private void HandleSuccess()
	{
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void HandleEnd()
	{
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 1)]
	private void DegradeTools(float hoursSpentCrafting)
	{
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "Update")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingOperation), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(BlueprintData), Member = "AmountToConsumeNow")]
	[Calls(Type = typeof(Inventory), Member = "RemoveAmountFromInventory")]
	[Calls(Type = typeof(BlueprintData), Member = "NumToConsumeNow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductPowderFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[CallsUnknownMethods(Count = 11)]
	private void ConsumeMaterialsUsedForCrafting(float hoursSpentCrafting)
	{
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "Update")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingOperation), Member = "GetModifiedCraftingDuration")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillGunsmithing")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "CraftedItem")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void ApplyCraftingProgress(float hoursSpentCrafting)
	{
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "Update")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerSkills), Member = "RollForSkillIncrease")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateSkillAfterCrafting(bool success)
	{
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "ApplyCraftingProgress")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private int GetModifiedCraftingDuration(int baseMinutes)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CraftingOperation()
	{
	}
}
