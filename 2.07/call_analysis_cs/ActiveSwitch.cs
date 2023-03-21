using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class ActiveSwitch : MonoBehaviour
{
	public int m_ActiveStateIndex;

	public GameObject[] m_States;

	private string m_Guid;

	private static List<ActiveSwitch> m_ActiveSwitches;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "Start")]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(Action_ActiveSwitch), Member = "DoWork")]
	[CallsUnknownMethods(Count = 3)]
	public void SetActiveStateIndex(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 3)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static ActiveSwitch FindActiveSwitchByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ActiveSwitch()
	{
	}
}
