using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class LootTableItemReference
{
	public AssetReferenceGearItem m_GearItem;

	public int m_Weight;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LootTableItemReference()
	{
	}
}
