using Cpp2ILInjected.CallAnalysis;

public class SceneMusicSaveData
{
	public bool m_HasBeenPlayed;

	public bool m_SupressExploreMusic;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SceneMusicSaveData()
	{
	}
}
