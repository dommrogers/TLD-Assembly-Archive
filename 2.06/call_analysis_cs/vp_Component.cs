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
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public vp_StateInfo DefaultState
	{
		[CallerCount(Count = 56)]
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 25)]
		get
		{
			return default(float);
		}
	}

	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Init()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void Update()
	{
	}

	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetState(string state, bool enabled)
	{
	}

	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "AllowState")]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void AllowState(string state, bool isAllowed)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "AllowState")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void AllowStateRecursively(string state, bool isAllowed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 1)]
	public bool StateEnabled(string stateName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_StateInfo), Member = ".ctor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	public void RefreshDefaultState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	public void ApplyPreset(vp_ComponentPreset preset)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsUnknownMethods(Count = 6)]
	public vp_ComponentPreset Load(string path)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public vp_ComponentPreset Load(TextAsset asset)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void Refresh()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSController), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = ".ctor")]
	[CallerCount(Count = 4)]
	public vp_Component()
	{
	}
}
