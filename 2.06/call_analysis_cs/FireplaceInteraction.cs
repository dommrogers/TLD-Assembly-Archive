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
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public Forge Forge
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
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
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallerCount(Count = 101224)]
	public abstract void PerformFireplaceInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool TooWindyToStart();

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanLightTorch()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Campfire), Member = "PerformFireplaceInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FireStart), Member = "ShowStartFire")]
	protected void AttemptToStartFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireplaceInteraction")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ShowFeedFire")]
	[CalledBy(Type = typeof(Campfire), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CallsUnknownMethods(Count = 1)]
	protected void AttemptToFeedFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	public virtual string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[DeduplicatedMethod]
	protected FireplaceInteraction()
	{
	}
}
