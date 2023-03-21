using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class OpenCloseManager
{
	public static List<OpenClose> m_OpenClosers;

	public static List<OpenClose> s_ActiveOpenClosers;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Add(OpenClose oc)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Remove(OpenClose oc)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OpenClose), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 10)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void UpdateAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public OpenCloseManager()
	{
	}
}
