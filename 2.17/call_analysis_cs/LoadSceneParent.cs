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

	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Register(LoadScene child)
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public void MarkChildrenExplored()
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(LoadSceneParent), Member = "FindLoadSceneParentByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static LoadSceneParent FindLoadSceneParentByPosition(LoadSceneParentSaveDataProxy proxy)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
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
