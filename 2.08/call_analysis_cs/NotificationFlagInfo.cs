using Cpp2ILInjected.CallAnalysis;

public class NotificationFlagInfo
{
	public string m_Key;

	public GearItem m_GearItem;

	public PanelType m_PanelType;

	public MainCategory m_MainCategory;

	public SubCategory m_SubCategory;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NotificationFlagInfo()
	{
	}
}
