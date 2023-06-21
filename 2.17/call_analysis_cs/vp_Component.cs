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
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	public vp_StateInfo DefaultState
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
	}

	public float Delta
	{
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "GetMouseDelta")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
		[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
		[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
		[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbHorisontalForce")]
		[CalledBy(Type = typeof(vp_FPSController), Member = "AbsorbUpForce")]
		[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return 0f;
		}
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Awake")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(vp_StateManager), Member = ".ctor")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetState(string state, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "AllowState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void AllowState(string state, bool isAllowed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void AllowStateRecursively(string state, bool isAllowed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 1)]
	public bool StateEnabled(string stateName)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(vp_StateInfo), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void RefreshDefaultState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ApplyPreset(vp_ComponentPreset preset)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_ComponentPreset Load(string path)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_ComponentPreset Load(TextAsset asset)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Refresh()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSController), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_Component()
	{
	}
}
