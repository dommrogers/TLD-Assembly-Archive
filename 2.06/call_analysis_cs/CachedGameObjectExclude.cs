using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObjectExclude : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CachedGameObjectExclude()
	{
	}
}
