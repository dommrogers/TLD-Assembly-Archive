using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ExploreMusic
{
	public string m_AudioID;

	public ExploreMusicTime m_TimeToPlay;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ExploreMusic()
	{
	}
}
