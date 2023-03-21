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
	[CallerCount(Count = 2)]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	public void SetCompletionFlag(string tag, bool state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void ConfigureInitialBlackboard(Blackboard bb);

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NCUtils), Member = "LogStateInfo")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExit()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	protected State_InvokeGraphBase()
	{
	}
}
