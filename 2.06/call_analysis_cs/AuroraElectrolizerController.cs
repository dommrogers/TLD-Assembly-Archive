using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class AuroraElectrolizerController : MonoBehaviour
{
	public class AuroraElectrolizerControllerSaveData
	{
		public struct VolumeSaveData
		{
			public string m_VolumeName;

			public bool m_IsActive;
		}

		public List<VolumeSaveData> m_VolumeSaveDataList;

		public string m_Id;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public AuroraElectrolizerControllerSaveData()
		{
		}
	}

	public List<AuroraElectrolizerControlVolume> m_ControlVolumeList;

	public GameObject m_ArtParent;

	private string m_Id;

	public static List<AuroraElectrolizerController> s_AuroraElectrolizerControllerList;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "FindRenderer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void PopulateVolumes()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private Renderer FindRenderer(GameObject obj)
	{
		return null;
	}

	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerVolume), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerVolume), Member = "DoWork")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 3)]
	public void SetPowerState(string volumeName, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 3)]
	public void SetPowerState(int volumeID, bool isActive)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Start")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerState), Member = "DoWork")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 3)]
	public void SetPowerStateAll(bool isActive)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 34)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "Initialize")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 13)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallsUnknownMethods(Count = 6)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AuroraElectrolizerController()
	{
	}
}
