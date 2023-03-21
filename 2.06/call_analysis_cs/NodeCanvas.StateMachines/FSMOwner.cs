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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FSMOwner), Member = "GetPreviousState")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(FSMOwner), Member = "get_currentDeepStateName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IState GetCurrentState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CalledBy(Type = typeof(FSMOwner), Member = "get_previousDeepStateName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FSM), Member = "GetStateNames")]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetStateNames()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	public FSMOwner()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
