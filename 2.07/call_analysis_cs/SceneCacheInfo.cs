using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneCacheInfo : MonoBehaviour
{
	public int m_NumCommonCachesActiveAtStart;

	public int m_NumRareCachesActiveAtStart;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SceneCacheInfo()
	{
	}
}
