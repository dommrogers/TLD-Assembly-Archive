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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Register(LoadScene child)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[CallsUnknownMethods(Count = 4)]
	public void MarkChildrenExplored()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(LoadSceneParent), Member = "FindLoadSceneParentByPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static LoadSceneParent FindLoadSceneParentByPosition(LoadSceneParentSaveDataProxy proxy)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LoadSceneParent()
	{
	}
}
