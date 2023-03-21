using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

public class LootTableManager : ScriptableObject
{
	private GameEvent m_ExperienceModeChanged;

	private List<LootTableData> m_LootTables;

	private static AsyncOperationHandle<LootTableManager> s_Instance;

	[CalledBy(Type = typeof(LootTableManager), Member = "RegisterLootTable")]
	[CalledBy(Type = typeof(LootTableManager), Member = "UnregisterLootTable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static LootTableManager GetInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LootTableManager), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterLootTable(LootTableData lootTable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LootTableManager), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterLootTable(LootTableData lootTable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	private void OnExperienceModeChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public LootTableManager()
	{
	}
}
