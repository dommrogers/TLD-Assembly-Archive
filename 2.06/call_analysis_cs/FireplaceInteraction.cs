using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

public abstract class FireplaceInteraction : BaseInteraction, ITorchLightInteraction
{
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private PanelReference<Panel_FeedFire> m_FeedFire;

	private PanelReference<Panel_FireStart> m_FireStart;

	private CookingSlot[] m_CookingSlots;

	private Fire _003CFire_003Ek__BackingField;

	private Forge _003CForge_003Ek__BackingField;

	public Fire Fire
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		private set
		{
		}
	}

	public Forge Forge
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 42)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(Campfire), Member = "Awake")]
	[CalledBy(Type = typeof(WoodStove), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	public abstract void PerformFireplaceInteraction();

	public abstract bool TooWindyToStart();

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanLightTorch()
	{
		return false;
	}

	[CalledBy(Type = typeof(Campfire), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FireStart), Member = "ShowStartFire")]
	[CallsUnknownMethods(Count = 1)]
	protected void AttemptToStartFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[CalledBy(Type = typeof(Campfire), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowFeedFire")]
	[CallsUnknownMethods(Count = 1)]
	protected void AttemptToFeedFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 23)]
	public virtual string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	protected FireplaceInteraction()
	{
	}
}
