using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadSceneParentSaveDataProxy
{
	public Vector3 m_Position;

	public string m_GUID;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LoadSceneParentSaveDataProxy()
	{
	}
}
