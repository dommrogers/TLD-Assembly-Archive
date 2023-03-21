using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SwitchBoxManager
{
	public static List<SwitchBox> m_SwitchBoxes;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Add(SwitchBox oc)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void Remove(SwitchBox oc)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SwitchBox), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 16)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(SwitchBox), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SwitchBoxManager()
	{
	}
}
