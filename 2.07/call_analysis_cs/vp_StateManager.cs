using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_StateManager
{
	private vp_Component m_Component;

	private List<vp_StateInfo> m_States;

	private string m_AppNotPlayingMessage;

	private string m_DefaultStateDisableMessage;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_Component), Member = "Awake")]
	public vp_StateManager(vp_Component component, List<vp_StateInfo> states)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "UpdateSprintState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__43_0")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnReloadComplete")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[CalledBy(Type = typeof(vp_Component), Member = "Awake")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_Component), Member = "SetState")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public void SetState(string state, bool isEnabled)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_Component), Member = "AllowState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(vp_Component), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "SetState")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "AllowState")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void CombineStates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void BringToFront(vp_StateInfo state)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool IsEnabled(string stateName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	public bool IsAllowed(string stateName)
	{
		return default(bool);
	}
}
