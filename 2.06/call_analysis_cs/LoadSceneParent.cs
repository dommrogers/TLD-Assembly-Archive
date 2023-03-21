using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class LoadSceneParent : MonoBehaviour
{
	public string m_GUID;

	private List<LoadScene> m_ChildLoadScenes;

	private bool m_StartHasBeenCalled;

	private static LoadSceneParentSaveDataProxy m_LoadSceneParentSaveDataProxy;

	private static List<LoadSceneParent> m_LoadSceneParentList;

	private static List<LoadSceneParentSaveDataProxy> m_MissingGuids;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Register(LoadScene child)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[CallsUnknownMethods(Count = 3)]
	public void MarkChildrenExplored()
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(LoadSceneParent), Member = "FindLoadSceneParentByPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 8)]
	private static LoadSceneParent FindLoadSceneParentByPosition(LoadSceneParentSaveDataProxy proxy)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public LoadSceneParent()
	{
	}
}
