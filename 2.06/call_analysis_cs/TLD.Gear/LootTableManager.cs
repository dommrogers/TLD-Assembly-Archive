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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LootTableManager), Member = "RegisterLootTable")]
	[CalledBy(Type = typeof(LootTableManager), Member = "UnregisterLootTable")]
	[CallsUnknownMethods(Count = 2)]
	public static LootTableManager GetInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LootTableManager), Member = "GetInstance")]
	public static void RegisterLootTable(LootTableData lootTable)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LootTableManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterLootTable(LootTableData lootTable)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	private void OnExperienceModeChanged()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public LootTableManager()
	{
	}
}
