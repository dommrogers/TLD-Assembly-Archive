using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public abstract class State_InvokeGraphBase : FSMState
{
	public Graph m_GraphAsset;

	protected GraphOwner m_ChildGraphOwner;

	protected bool m_JustStarted;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void OnInit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 4)]
	public void SetCompletionFlag(string tag, bool state)
	{
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	protected abstract void ConfigureInitialBlackboard(Blackboard bb);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnEnter()
	{
	}

	[Calls(Type = typeof(NCUtils), Member = "LogStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void OnPause()
	{
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected State_InvokeGraphBase()
	{
	}
}
