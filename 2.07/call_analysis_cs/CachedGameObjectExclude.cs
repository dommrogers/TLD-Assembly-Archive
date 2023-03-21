using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObjectExclude : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CachedGameObjectExclude()
	{
	}
}
