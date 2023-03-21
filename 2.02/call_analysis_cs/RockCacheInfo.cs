using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RockCacheInfo
{
	public string m_Guid;

	public string m_CustomName;

	public string m_SceneName;

	public Vector3 m_MapDetailPosition;

	public string m_UserText;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RockCacheInfo()
	{
	}
}
