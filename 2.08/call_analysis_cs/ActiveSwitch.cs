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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_ActiveSwitch), Member = "DoWork")]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(ActiveSwitch), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void SetActiveStateIndex(int index)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static ActiveSwitch FindActiveSwitchByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ActiveSwitch()
	{
	}
}
