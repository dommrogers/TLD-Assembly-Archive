using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadSceneSaveDataProxy
{
	public Vector3 m_Position;

	public string m_GUID;

	public bool m_Explored;

	public string m_GameGuid;

	public string m_LockSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LoadSceneSaveDataProxy()
	{
	}
}
