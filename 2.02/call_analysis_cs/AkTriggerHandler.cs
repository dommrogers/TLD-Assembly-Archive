using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkTriggerHandler : MonoBehaviour
{
	public const int AWAKE_TRIGGER_ID = 1151176110;

	public const int START_TRIGGER_ID = 1281810935;

	public const int DESTROY_TRIGGER_ID = -358577003;

	public const int MAX_NB_TRIGGERS = 32;

	public static Dictionary<uint, string> triggerTypes;

	private bool didDestroy;

	public List<int> triggerList;

	public bool useOtherObject;

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract void HandleEvent(GameObject in_gameObject);

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "RegisterTriggers")]
	[CalledBy(Type = typeof(AkBank), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CalledBy(Type = typeof(AkDragDropTriggerHandler), Member = "Awake")]
	[CallsUnknownMethods(Count = 12)]
	protected virtual void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AkDragDropTriggerHandler), Member = "Start")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Start")]
	[CalledBy(Type = typeof(AkRoom), Member = "Start")]
	[CalledBy(Type = typeof(AkBank), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(AkEvent), Member = "Start")]
	protected virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected virtual void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "OnDestroy")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "UnregisterTriggers")]
	[CalledBy(Type = typeof(AkBank), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 12)]
	public void DoDestroy()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CalledBy(Type = typeof(AkTriggerHandler), Member = "Awake")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AkBank), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	protected void RegisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkBank), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	protected void UnregisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AkRoomPortal), Member = ".ctor")]
	[CalledBy(Type = typeof(AkRoom), Member = ".ctor")]
	[CalledBy(Type = typeof(AkDragDropTriggerHandler), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AkBank), Member = ".ctor")]
	protected AkTriggerHandler()
	{
	}
}
