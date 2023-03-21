using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerStateTransitions : ScriptableObject
{
	private PlayerAnimation.StateFlags[] m_ValidTransitions;

	private PlayerAnimation.StateFlags[] m_InvalidTransitions;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsValidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsInvalidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayerStateTransitions()
	{
	}
}
