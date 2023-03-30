using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

namespace InteractiveObjects;

public class Transmitter : MonoBehaviour
{
	private TransmitterData m_TransmitterData;

	private OpenClose m_SwitchHandle;

	private bool m_EarlyWindowStartAllowed;

	private bool m_LateWindowStartAllowed;

	private float m_DurationOverrideHoursMin;

	private float m_DurationOverrideHoursMax;

	private readonly List<RepairableInteractiveItem> m_ChildrenRepairables;

	private TransmitterRuntimeState m_RuntimeState;

	public TransmitterData TransmitterData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public bool IsFixed
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
		[CallsUnknownMethods(Count = 1)]
		private set
		{
		}
	}

	public bool IsOpen
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool IsDiscovered
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool IsActive
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[Calls(Type = typeof(Transmitter), Member = "UpdateRuntimeState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void OnOpenSwitch()
	{
	}

	[CallerCount(Count = 0)]
	public void OnCloseSwitch()
	{
	}

	[CallerCount(Count = 0)]
	public void OnOpenTransmitterDoor()
	{
	}

	[CalledBy(Type = typeof(Transmitter), Member = "Awake")]
	[CalledBy(Type = typeof(TransmitterManager), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(RepairableInteractiveItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateRuntimeState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = "GetRepairableStateForGuid")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void OnItemRepaired(RepairableInteractiveItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	private void ForceAurora()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Transmitter()
	{
	}
}
