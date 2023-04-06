using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

namespace InteractiveObjects;

public class RepairableInteractiveItem : AnimatedTimedHoldInteraction
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

	public RequiredGearItem[] m_RequiredGearItems;

	public LocalizedString m_ItemDisplayName;

	public GameObject m_FixedGameobject;

	public GameObject m_BrokenGameobject;

	private bool _003CIsRepaired_003Ek__BackingField;

	private AK.Wwise.Event m_HoldStartAudioEvent;

	private AK.Wwise.Event m_HoldCancelAudioEvent;

	private AK.Wwise.Event m_HoldEndAudioEvent;

	public bool IsRepaired
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
		[CallerCount(Count = 1)]
		private set
		{
		}
	}

	public event Action<RepairableInteractiveItem> ItemRepaired
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(Transmitter), Member = "UpdateRuntimeState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RepairableInteractiveItem), Member = "UpdateText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(RepairableItemSaveState repairableItemSaveState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(RepairableInteractiveItem), Member = "UpdateText")]
	public override void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RepairableInteractiveItem), Member = "HasRequiredGears")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformHold()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(RepairableInteractiveItem), Member = "UpdateText")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void CancelHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnAnimatedInteractionBegin()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnAnimatedInteractionEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveRequiredGearsFromInventory()
	{
	}

	[CalledBy(Type = typeof(RepairableInteractiveItem), Member = "PerformHold")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasRequiredGears()
	{
		return false;
	}

	[CalledBy(Type = typeof(RepairableInteractiveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(RepairableInteractiveItem), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(RepairableInteractiveItem), Member = "UpdateInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateText()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RepairableInteractiveItem()
	{
	}
}
