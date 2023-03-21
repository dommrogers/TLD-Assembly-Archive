using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class CollectionManager
{
	public static Dictionary<int, string> m_UnlockedCairnsDict;

	public static HashSet<string> m_UnlockedAuroraSet;

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnlockCairn(Cairn cairn)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "GetPrefabName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "GetPrefabName")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CallsUnknownMethods(Count = 2)]
	public static void UnlockAuroraScreen(AuroraScreenDisplay screen)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 1)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public CollectionManager()
	{
	}
}
