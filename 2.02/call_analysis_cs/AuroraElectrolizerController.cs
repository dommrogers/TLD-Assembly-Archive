using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
		[CallerCount(Count = 2)]
		public AuroraElectrolizerControllerSaveData()
		{
		}
	}

	public List<AuroraElectrolizerControlVolume> m_ControlVolumeList;

	public GameObject m_ArtParent;

	private string m_Id;

	public static List<AuroraElectrolizerController> s_AuroraElectrolizerControllerList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "FindRenderer")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "FindRenderer")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	private void PopulateVolumes()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "PopulateVolumes")]
	[CallsUnknownMethods(Count = 1)]
	private Renderer FindRenderer(GameObject obj)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerVolume), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerVolume), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	public void SetPowerState(string volumeName, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 3)]
	public void SetPowerState(int volumeID, bool isActive)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerState), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SetAuroraElectrolyzerControllerState), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Start")]
	public void SetPowerStateAll(bool isActive)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 37)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "Initialize")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraElectrolizerController()
	{
	}
}
