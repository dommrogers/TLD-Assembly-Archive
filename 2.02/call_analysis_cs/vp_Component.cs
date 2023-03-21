using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_Component : MonoBehaviour
{
	public bool Persist;

	protected vp_StateManager m_StateManager;

	public List<vp_StateInfo> States;

	protected vp_StateInfo m_DefaultState;

	protected bool m_Initialized;

	public vp_StateManager StateManager
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	public vp_StateInfo DefaultState
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public float Delta
	{
		[CallerCount(Count = 22)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(float);
		}
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Awake")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = ".ctor")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	public void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Init()
	{
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetState(string state, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ResetState()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "AllowState")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void AllowState(string state, bool isAllowed)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "AllowState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void AllowStateRecursively(string state, bool isAllowed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	public bool StateEnabled(string stateName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_StateInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(vp_StateInfo), Member = ".ctor")]
	public void RefreshDefaultState()
	{
	}

	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	public void ApplyPreset(vp_ComponentPreset preset)
	{
	}

	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public vp_ComponentPreset Load(string path)
	{
		return null;
	}

	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public vp_ComponentPreset Load(TextAsset asset)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void Refresh()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSController), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = ".ctor")]
	public vp_Component()
	{
	}
}
