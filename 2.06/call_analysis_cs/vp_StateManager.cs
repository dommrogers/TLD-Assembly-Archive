using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_StateManager
{
	private vp_Component m_Component;

	private List<vp_StateInfo> m_States;

	private string m_AppNotPlayingMessage;

	private string m_DefaultStateDisableMessage;

	[CalledBy(Type = typeof(vp_Component), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public vp_StateManager(vp_Component component, List<vp_StateInfo> states)
	{
	}

	[CalledBy(Type = typeof(vp_Component), Member = "Awake")]
	[CalledBy(Type = typeof(vp_Component), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "UpdateSprintState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnReloadComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CallerCount(Count = 19)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetState(string state, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(vp_Component), Member = "AllowState")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_Component), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CallerCount(Count = 6)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(vp_StateManager), Member = "SetState")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "AllowState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void CombineStates()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsUnknownMethods(Count = 1)]
	public void BringToFront(vp_StateInfo state)
	{
	}

	[CalledBy(Type = typeof(vp_Component), Member = "StateEnabled")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "UpdateSprintState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[CallerCount(Count = 24)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled(string stateName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsAllowed(string stateName)
	{
		return false;
	}
}
