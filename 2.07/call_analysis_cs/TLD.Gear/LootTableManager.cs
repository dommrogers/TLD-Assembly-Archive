using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

public class LootTableManager : ScriptableObject
{
	private GameEvent m_ExperienceModeChanged;

	private List<LootTableData> m_LootTables;

	private static AsyncOperationHandle<LootTableManager> s_Instance;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LootTableManager), Member = "UnregisterLootTable")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(LootTableManager), Member = "RegisterLootTable")]
	public static LootTableManager GetInstance()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LootTableManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterLootTable(LootTableData lootTable)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void UnregisterLootTable(LootTableData lootTable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[CallsUnknownMethods(Count = 4)]
	private void OnExperienceModeChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public LootTableManager()
	{
	}
}
