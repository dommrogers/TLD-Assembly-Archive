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

	public abstract void HandleEvent(GameObject in_gameObject);

	[CalledBy(Type = typeof(AkBank), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CalledBy(Type = typeof(AkDragDropTriggerHandler), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "RegisterTriggers")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	protected virtual void Awake()
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "Start")]
	[CalledBy(Type = typeof(AkEvent), Member = "Start")]
	[CalledBy(Type = typeof(AkRoom), Member = "Start")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Start")]
	[CalledBy(Type = typeof(AkDragDropTriggerHandler), Member = "Start")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected virtual void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "OnDestroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "UnregisterTriggers")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public void DoDestroy()
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CalledBy(Type = typeof(AkTriggerHandler), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	protected void RegisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	protected void UnregisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = ".ctor")]
	[CalledBy(Type = typeof(AkRoom), Member = ".ctor")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = ".ctor")]
	[CalledBy(Type = typeof(AkDragDropTriggerHandler), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	protected AkTriggerHandler()
	{
	}
}
