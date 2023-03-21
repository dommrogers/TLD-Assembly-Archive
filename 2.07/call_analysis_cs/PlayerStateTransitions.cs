using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerStateTransitions : ScriptableObject
{
	private PlayerAnimation.StateFlags[] m_ValidTransitions;

	private PlayerAnimation.StateFlags[] m_InvalidTransitions;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsValidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsInvalidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayerStateTransitions()
	{
	}
}
