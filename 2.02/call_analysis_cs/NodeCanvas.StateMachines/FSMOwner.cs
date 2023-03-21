using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class FSMOwner : GraphOwner<FSM>
{
	public string currentRootStateName
	{
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string previousRootStateName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string currentDeepStateName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FSMOwner), Member = "GetCurrentState")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string previousDeepStateName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(FSMOwner), Member = "GetPreviousState")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_currentDeepStateName")]
	[CallsUnknownMethods(Count = 4)]
	public IState GetCurrentState(bool includeSubFSMs = true)
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_previousDeepStateName")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	public IState GetPreviousState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FSM), Member = "TriggerState")]
	[CallsUnknownMethods(Count = 1)]
	public IState TriggerState(string stateName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FSM), Member = "GetStateNames")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public string[] GetStateNames()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public FSMOwner()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
