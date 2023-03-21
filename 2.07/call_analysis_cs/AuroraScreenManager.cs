using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public static class AuroraScreenManager
{
	public class SaveProxy
	{
		public string m_AssignedPrefabsSerialized;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SaveProxy()
		{
		}
	}

	private static HashSet<string> s_PrefabsInUse;

	private static Dictionary<string, string> s_AssignedPrefabs;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 5)]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void AssociatePrefabWithId(string guid, string prefabName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetPrefabForId(string id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPrefabInUse(string prefabName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void MarkPrefabAsInUse(string prefabName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void RemovePrefabAssociation(string id)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}
}
