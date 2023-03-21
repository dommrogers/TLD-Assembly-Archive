using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;

namespace TLD.Interactions;

public abstract class BaseInteraction : MonoBehaviour, IInteraction
{
	public LocalizedString m_DefaultHoverText;

	public List<InteractionEventEntry> m_EventEntries;

	private string _003CHoverText_003Ek__BackingField;

	private bool m_CanInteract;

	public string HoverText
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
		[CallerCount(Count = 40)]
		set
		{
		}
	}

	public bool IsEnabled
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public virtual bool CanInteract
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Start()
	{
	}

	[CalledBy(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "InitializeInteraction")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BreakDown), Member = "InitializeInteraction")]
	public virtual void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public virtual void UpdateInteraction(float deltaTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract bool PerformInteraction();

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public virtual void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1299)]
	[CallsUnknownMethods(Count = 1)]
	public GameObject GetInteractiveObject()
	{
		return null;
	}

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseInteraction), Member = "TryFindEventForEventType")]
	[Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	public void TriggerEvent(InteractionEventType eventType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "FindOrAddEventForEventType")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddEventCallback(InteractionEventType eventType, UnityAction<BaseInteraction> eventCallback)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CalledBy(Type = typeof(BaseInteraction), Member = "FindOrAddEventForEventType")]
	[CallsUnknownMethods(Count = 5)]
	private bool TryFindEventForEventType(InteractionEventType eventType, out InteractionEvent interactionEvent)
	{
		interactionEvent = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TryFindEventForEventType")]
	[CalledBy(Type = typeof(BaseInteraction), Member = "AddEventCallback")]
	[CallsUnknownMethods(Count = 2)]
	private InteractionEvent FindOrAddEventForEventType(InteractionEventType eventType)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseHoldInteraction), Member = ".ctor")]
	[CalledBy(Type = typeof(SimpleInteraction), Member = ".ctor")]
	[CalledBy(Type = typeof(WoodStove), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TimedHoldInteraction), Member = ".ctor")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = ".ctor")]
	[CalledBy(Type = typeof(RopeExitPoint), Member = ".ctor")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = ".ctor")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = ".ctor")]
	[CalledBy(Type = typeof(CookingSlot), Member = ".ctor")]
	[CalledBy(Type = typeof(Campfire), Member = ".ctor")]
	[CalledBy(Type = typeof(BreakDown), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	protected BaseInteraction()
	{
	}
}
