using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ExploreMusic
{
	public Event m_Event;

	public string m_AudioID;

	public ExploreMusicTime m_TimeToPlay;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ExploreMusic()
	{
	}
}
