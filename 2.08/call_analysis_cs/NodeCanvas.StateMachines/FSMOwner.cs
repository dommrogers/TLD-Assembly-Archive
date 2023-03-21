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
		[Calls(Type = typeof(FSMOwner), Member = "GetPreviousState")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FSMOwner), Member = "get_previousDeepStateName")]
	public IState GetPreviousState(bool includeSubFSMs = true)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSM), Member = "TriggerState")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FSMOwner()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
