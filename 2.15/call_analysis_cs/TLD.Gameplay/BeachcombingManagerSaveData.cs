using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public class BeachcombingManagerSaveData
{
	private const float DEFAULT_TIME_SINCE_LAST = -1000f;

	public float m_TimeAtLastBlizzard;

	public bool m_BlizzardFullyActive;

	public int m_CurrentBlizzardID;

	[CallerCount(Count = 0)]
	public BeachcombingManagerSaveData()
	{
	}
}
