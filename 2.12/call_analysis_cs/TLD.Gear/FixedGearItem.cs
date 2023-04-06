using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gear;

[Serializable]
public class FixedGearItem
{
	public AssetReferenceGearItem m_GearItem;

	public int m_Count;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FixedGearItem()
	{
	}
}
