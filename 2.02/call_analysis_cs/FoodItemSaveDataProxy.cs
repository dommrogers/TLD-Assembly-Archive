using Cpp2ILInjected.CallAnalysis;

public class FoodItemSaveDataProxy
{
	public float m_CaloriesRemainingProxy;

	public float m_CaloriesTotal;

	public bool m_Opened;

	public float m_HeatPercent;

	public float m_HoursPlayed;

	public bool m_HarvestedByPlayer;

	public int m_NumTimesHeatedUp;

	public bool m_Packaged;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FoodItemSaveDataProxy()
	{
	}
}
