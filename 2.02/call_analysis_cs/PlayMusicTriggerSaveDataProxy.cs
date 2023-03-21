using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayMusicTriggerSaveDataProxy
{
	public Vector3 m_Position;

	public int m_NumPlays;

	public string m_Guid;

	public string m_ObjectLinkGuid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayMusicTriggerSaveDataProxy()
	{
	}
}
