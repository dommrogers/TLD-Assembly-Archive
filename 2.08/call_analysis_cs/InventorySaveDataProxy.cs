using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class InventorySaveDataProxy
{
	public List<InventoryItemSaveData> m_SerializedItems;

	public int[] m_QuickSelectInstanceIDs;

	public bool m_ForceOverrideWeight;

	public float m_OverridedWeight;

	public bool m_ConsumedCoffee;

	public bool m_ConsumedRosehipTea;

	public bool m_ConsumedReishiTea;

	public bool m_ConsumedOldMansBeardDressing;

	public bool m_SuppressScentIndicator;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public InventorySaveDataProxy()
	{
	}
}
