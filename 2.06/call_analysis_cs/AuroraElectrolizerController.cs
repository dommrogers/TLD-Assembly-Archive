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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	private void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "FindRenderer")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "FindRenderer")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PopulateVolumes()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Renderer FindRenderer(GameObject obj)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerVolume), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerVolume), Member = "DoWork")]
	public void SetPowerState(string volumeName, bool isActive)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetPowerState(int volumeID, bool isActive)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Start")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerState), Member = "DoWork")]
	[CallsUnknownMethods(Count = 3)]
	public void SetPowerStateAll(bool isActive)
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "Initialize")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 13)]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
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
