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
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 36)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BreakDown), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	public virtual void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction()
	{
	}

	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
	public virtual void UpdateInteraction(float deltaTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool PerformInteraction();

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public virtual void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1446)]
	[CallsUnknownMethods(Count = 1)]
	public GameObject GetInteractiveObject()
	{
		return null;
	}

	[Calls(Type = typeof(BaseInteraction), Member = "TryFindEventForEventType")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 30)]
	public void TriggerEvent(InteractionEventType eventType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "FindOrAddEventForEventType")]
	[Calls(Type = typeof(UnityEventBase), Member = "AddCall")]
	[CallsUnknownMethods(Count = 1)]
	public void AddEventCallback(InteractionEventType eventType, UnityAction<BaseInteraction> eventCallback)
	{
	}

	[CalledBy(Type = typeof(BaseInteraction), Member = "FindOrAddEventForEventType")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsUnknownMethods(Count = 4)]
	private bool TryFindEventForEventType(InteractionEventType eventType, out InteractionEvent interactionEvent)
	{
		interactionEvent = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseInteraction), Member = "AddEventCallback")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TryFindEventForEventType")]
	[CallerCount(Count = 1)]
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
