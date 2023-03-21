using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class GearSpawnInOldSaves : MonoBehaviour
{
	private static List<string> m_SceneGuids;

	private static List<string> m_RestoredGuids;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Add(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearManager), Member = "ShouldDeleteActiveGearItem")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static bool HasSpawned(string guid)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearSpawnInOldSaves()
	{
	}
}
