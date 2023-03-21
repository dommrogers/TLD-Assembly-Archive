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

	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	public vp_StateManager(vp_Component component, List<vp_StateInfo> states)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__42_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__42_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__42_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "UpdateSprintState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__42_0")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "<ReenableWeaponStatesIn>b__42_0")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnReloadComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(vp_Component), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(vp_Component), Member = "SetState")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 18)]
	public void SetState(string state, bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Component), Member = "AllowState")]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ResetState")]
	[CallerCount(Count = 6)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_Component), Member = "ResetState")]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "AllowState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void CombineStates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void BringToFront(vp_StateInfo state)
	{
	}

	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	public bool IsEnabled(string stateName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public bool IsAllowed(string stateName)
	{
		return default(bool);
	}
}
