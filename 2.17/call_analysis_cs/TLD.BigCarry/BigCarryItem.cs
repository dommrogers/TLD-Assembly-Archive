using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.BigCarry;

public abstract class BigCarryItem : BaseInteraction
{
	public AssetReferenceBigCarryItem m_AssetReference;

	public HeldItemInPlacementZone m_HeldItemPlacementZone;

	public AssetReferenceGearItem m_FPHDummyGearItem;

	public float m_PlacementDistance;

	private PickupIntensityAudio m_LowIntensityAudio;

	private PickupIntensityAudio m_MediumIntensityAudio;

	private PickupIntensityAudio m_HighIntensityAudio;

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private string _003CGUID_003Ek__BackingField;

	private bool _003CIsCarried_003Ek__BackingField;

	protected List<ActionPickerItemData> m_ActionPickerData;

	protected ActionPickerItemData m_CarryPickerData;

	public string GUID
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 64)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	public bool IsCarried
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

	public virtual int IdleAnimationStateHash
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BigCarrySystem), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Initialize()
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "FindOrCreateBigCarryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void SetGUID(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "RemoveItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public virtual BigCarryItemSaveData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void Deserialize(BigCarryItemSaveData data, bool isCarried)
	{
	}

	[CallerCount(Count = 0)]
	public AK.Wwise.Event GetHoistAudio(bool pickingUp, BigCarryPickupIntensity intensity)
	{
		return null;
	}

	public abstract void OnCarried();

	public abstract void OnRestored(bool replacedOriginal);

	public abstract void OnDropped();

	public abstract void OnBeginPlacement();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void UpdateItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual float GetMovementSpeedModifier(bool isSprinting)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual float GetTurnSpeedModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void InitializeActionPickerItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[CallsUnknownMethods(Count = 2)]
	protected virtual bool CanInteractWithItem()
	{
		return false;
	}

	protected abstract void BuildActionPickerData();

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(BigCarrySystem), Member = "Carry")]
	[CallsUnknownMethods(Count = 1)]
	private void CarryCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected BigCarryItem()
	{
	}
}
