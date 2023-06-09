using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gear;

[Serializable]
public class RandomGearItem
{
	public LootTableData m_LootTable;

	public int m_MinCount;

	public int m_MaxCount;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RandomGearItem()
	{
	}
}
