using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerStateTransitions : ScriptableObject
{
	private PlayerAnimation.StateFlags[] m_ValidTransitions;

	private PlayerAnimation.StateFlags[] m_InvalidTransitions;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsValidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsInvalidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PlayerStateTransitions()
	{
	}
}
