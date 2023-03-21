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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(WoodStove), Member = "Awake")]
	[CalledBy(Type = typeof(Campfire), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
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
	[CallerCount(Count = 101261)]
	public abstract void PerformFireplaceInteraction();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	public abstract bool TooWindyToStart();

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowFeedFire")]
	protected void AttemptToFeedFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public virtual string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected FireplaceInteraction()
	{
	}
}
