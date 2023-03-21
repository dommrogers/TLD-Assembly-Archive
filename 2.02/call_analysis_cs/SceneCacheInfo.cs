using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneCacheInfo : MonoBehaviour
{
	public int m_NumCommonCachesActiveAtStart;

	public int m_NumRareCachesActiveAtStart;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SceneCacheInfo()
	{
	}
}
