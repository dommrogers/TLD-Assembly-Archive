using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class FSMOwner : GraphOwner<FSM>
{
	public string currentRootStateName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string previousRootStateName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string currentDeepStateName
	{
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_currentDeepStateName")]
	[CallsUnknownMethods(Count = 3)]
	public IState GetCurrentState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_previousDeepStateName")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public IState GetPreviousState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FSM), Member = "TriggerState")]
	[CallsUnknownMethods(Count = 1)]
	public IState TriggerState(string stateName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FSM), Member = "GetStateNames")]
	public string[] GetStateNames()
	{
		return null;
	}

	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public FSMOwner()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
