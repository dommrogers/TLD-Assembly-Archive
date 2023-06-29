using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Serialization;
using UnityEngine;

namespace TLD.BigCarry;

public class BodyBigCarryItem : BigCarryItem
{
	private class BodyBigCarryItemSaveData
	{
		public bool m_HasBeenDropped;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public BodyBigCarryItemSaveData()
		{
		}
	}

	private ShowOnMapItem m_ShowItemOnMap;

	private AnimationStateRef m_DropAnimation;

	private AnimationStateRef m_DroppedIdleAnimation;

	private AnimationStateRef m_PlacementMeshIdleAnimation;

	private readonly int m_IdleAnimationStateHash;

	private bool _003CReplacedOriginal_003Ek__BackingField;

	private Bed _003CBed_003Ek__BackingField;

	private NPC _003CNPC_003Ek__BackingField;

	private bool m_HasBeenDropped;

	private Animator m_Animator;

	private Container m_Container;

	private ActionPickerItemData m_DiagnosePickerData;

	private ActionPickerItemData m_SearchPickerData;

	private static BodyBigCarryItemSaveData m_BodyBigCarryItemSaveData;

	public override int IdleAnimationStateHash
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public bool ReplacedOriginal
	{
		[CompilerGenerated]
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

	public Bed Bed
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		private set
		{
		}
	}

	public NPC NPC
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarryItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public override BigCarryItemSaveData Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarryItem), Member = "Deserialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Deserialize(BigCarryItemSaveData data, bool isCarried)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void OnCarried()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnRestored(bool replacedOriginal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnDropped()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBeginPlacement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "IsActive")]
	[Calls(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool CanInteractWithItem()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected override void InitializeActionPickerItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AreAllAfflictionTreated")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsUnknownMethods(Count = 3)]
	protected override void BuildActionPickerData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallsUnknownMethods(Count = 1)]
	private void DiagnoseCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Container), Member = "ShowContainerContents")]
	[CallsUnknownMethods(Count = 1)]
	private void SearchCallback()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public void OnPlacedInBed(Bed bed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRemovedFromBed(Bed bed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public BodyBigCarryItem()
	{
	}
}
