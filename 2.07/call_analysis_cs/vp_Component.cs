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
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	public vp_StateInfo DefaultState
	{
		[CallerCount(Count = 53)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public float Delta
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 25)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(float);
		}
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Awake")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = ".ctor")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	protected virtual void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "AllowState")]
	public virtual void AllowState(string state, bool isAllowed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[Calls(Type = typeof(vp_StateInfo), Member = ".ctor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 4)]
	public void RefreshDefaultState()
	{
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallerCount(Count = 0)]
	public void ApplyPreset(vp_ComponentPreset preset)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	public vp_ComponentPreset Load(string path)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public vp_ComponentPreset Load(TextAsset asset)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void Refresh()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSController), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public vp_Component()
	{
	}
}
