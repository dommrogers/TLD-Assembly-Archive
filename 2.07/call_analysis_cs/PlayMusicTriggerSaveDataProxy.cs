using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayMusicTriggerSaveDataProxy
{
	public Vector3 m_Position;

	public int m_NumPlays;

	public string m_Guid;

	public string m_ObjectLinkGuid;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayMusicTriggerSaveDataProxy()
	{
	}
}
