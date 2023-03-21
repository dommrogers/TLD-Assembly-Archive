using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuid")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Register(LoadScene child)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void MarkChildrenExplored()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(LoadSceneParent), Member = "FindLoadSceneParentByPosition")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadSceneParent), Member = "Deserialize")]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private static LoadSceneParent FindLoadSceneParentByPosition(LoadSceneParentSaveDataProxy proxy)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 17)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public LoadSceneParent()
	{
	}
}
