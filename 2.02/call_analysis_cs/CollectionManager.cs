using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class CollectionManager
{
	public static Dictionary<int, string> m_UnlockedCairnsDict;

	public static HashSet<string> m_UnlockedAuroraSet;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void UnlockCairn(Cairn cairn)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "GetPrefabName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "GetPrefabName")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CallsUnknownMethods(Count = 4)]
	public static void UnlockAuroraScreen(AuroraScreenDisplay screen)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 2)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CollectionManager()
	{
	}
}
