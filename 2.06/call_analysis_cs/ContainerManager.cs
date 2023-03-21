using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class ContainerManager
{
	public static List<Container> m_Containers;

	public static List<Container> m_CorpseContainers;

	public static List<Container> s_ActiveContainers;

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Container), Member = "Serialize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static string Serialize()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Container), Member = "Deserialize")]
	[Calls(Type = typeof(ContainerManager), Member = "FindContainerByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ContainerManager), Member = "FindContainerByGuid")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	public static void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[Calls(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Container), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ContainerManager), Member = "FindContainerByPosition")]
	[Calls(Type = typeof(ContainerManager), Member = "FindContainerByGuid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAdditive(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DisableAll()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "UpdateContainer")]
	public static void UpdateAll()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CallsUnknownMethods(Count = 3)]
	private static Container FindContainerByPosition(ContainerSaveData csd)
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static Container FindContainerByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldUseSavedContainerPosition(Vector3 scenePos, Vector3 savedPos)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ContainerManager()
	{
	}
}
