using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public static class RandomTableDataManager
{
	private static readonly List<RandomTableData> m_InitializedData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetLootTables()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool DoesTableNeedInitialization(RandomTableData data)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetTableDirty(RandomTableData data)
	{
	}
}
