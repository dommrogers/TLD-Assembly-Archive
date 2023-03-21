using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class ActiveSwitch : MonoBehaviour
{
	public int m_ActiveStateIndex;

	public GameObject[] m_States;

	private string m_Guid;

	private static List<ActiveSwitch> m_ActiveSwitches;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Action_ActiveSwitch), Member = "DoWork")]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void SetActiveStateIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActiveSwitch), Member = "FindActiveSwitchByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 4)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static ActiveSwitch FindActiveSwitchByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ActiveSwitch()
	{
	}
}
