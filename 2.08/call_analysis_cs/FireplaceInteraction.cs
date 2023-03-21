using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;

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
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		private set
		{
		}
	}

	public Forge Forge
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Campfire), Member = "Awake")]
	[CalledBy(Type = typeof(WoodStove), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void PerformFireplaceInteraction();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	public abstract bool TooWindyToStart();

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool CanLightTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "ShowStartFire")]
	[CalledBy(Type = typeof(Campfire), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CallsUnknownMethods(Count = 1)]
	protected void AttemptToStartFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(Campfire), Member = "PerformFireplaceInteraction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowFeedFire")]
	protected void AttemptToFeedFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
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
