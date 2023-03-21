using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenCloseManager
{
	public static List<OpenClose> m_OpenClosers;

	public static List<OpenClose> s_ActiveOpenClosers;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Add(OpenClose oc)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static void Remove(OpenClose oc)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OpenClose), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 16)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(OpenClose), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void UpdateAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OpenCloseManager()
	{
	}
}
