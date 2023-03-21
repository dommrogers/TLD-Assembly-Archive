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
		[CallerCount(Count = 61)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 38)]
		set
		{
		}
	}

	public bool IsEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public virtual bool CanInteract
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Start()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BreakDown), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[CallerCount(Count = 4)]
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

	public abstract bool PerformInteraction();

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public virtual void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1552)]
	[CallsUnknownMethods(Count = 1)]
	public GameObject GetInteractiveObject()
	{
		return null;
	}

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(BaseInteraction), Member = "TryFindEventForEventType")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[CallsUnknownMethods(Count = 1)]
	public void TriggerEvent(InteractionEventType eventType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "FindOrAddEventForEventType")]
	[Calls(Type = typeof(UnityEventBase), Member = "AddCall")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddEventCallback(InteractionEventType eventType, UnityAction<BaseInteraction> eventCallback)
	{
	}

	[CalledBy(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CalledBy(Type = typeof(BaseInteraction), Member = "FindOrAddEventForEventType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private bool TryFindEventForEventType(InteractionEventType eventType, out InteractionEvent interactionEvent)
	{
		interactionEvent = null;
		return false;
	}

	[CalledBy(Type = typeof(BaseInteraction), Member = "AddEventCallback")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TryFindEventForEventType")]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private InteractionEvent FindOrAddEventForEventType(InteractionEventType eventType)
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	protected BaseInteraction()
	{
	}
}
