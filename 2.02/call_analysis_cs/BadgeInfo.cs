using Cpp2ILInjected.CallAnalysis;

public class BadgeInfo
{
	public string m_SpriteName;

	public string m_NameLocID;

	public string m_Desc;

	public bool m_Unlocked;

	public float m_NormalizedProgress;

	public string m_Benefit;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BadgeInfo()
	{
	}
}
