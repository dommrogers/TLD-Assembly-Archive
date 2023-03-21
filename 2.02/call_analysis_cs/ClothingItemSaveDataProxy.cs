using Cpp2ILInjected.CallAnalysis;

public class ClothingItemSaveDataProxy
{
	public bool m_WearingProxy;

	public float m_PercentWet;

	public float m_PercentFrozen;

	public float m_HoursPlayed;

	public float m_HoursRemainingOnCloseFire;

	public bool m_DroppedIndoors;

	public bool m_HasEquippedData;

	public int m_EquippedLayerIndex;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ClothingItemSaveDataProxy()
	{
	}
}
