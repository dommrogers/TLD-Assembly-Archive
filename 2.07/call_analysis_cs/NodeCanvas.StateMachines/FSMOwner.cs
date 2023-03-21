using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class FSMOwner : GraphOwner<FSM>
{
	public string currentRootStateName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string previousRootStateName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string currentDeepStateName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(FSMOwner), Member = "GetCurrentState")]
		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_currentDeepStateName")]
	[CallsUnknownMethods(Count = 3)]
	public IState GetCurrentState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_previousDeepStateName")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public IState GetPreviousState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSM), Member = "TriggerState")]
	[CallsUnknownMethods(Count = 1)]
	public IState TriggerState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSM), Member = "GetStateNames")]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetStateNames()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public FSMOwner()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
