using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObjectExclude : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CachedGameObjectExclude()
	{
	}
}
