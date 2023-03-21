using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public static class AuroraScreenManager
{
	public class SaveProxy
	{
		public string m_AssignedPrefabsSerialized;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SaveProxy()
		{
		}
	}

	private static HashSet<string> s_PrefabsInUse;

	private static Dictionary<string, string> s_AssignedPrefabs;

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void AssociatePrefabWithId(string guid, string prefabName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static string GetPrefabForId(string id)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static bool IsPrefabInUse(string prefabName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void MarkPrefabAsInUse(string prefabName)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public static void RemovePrefabAssociation(string id)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static void Reset()
	{
	}
}
