using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObjectExclude : MonoBehaviour
{
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public CachedGameObjectExclude()
	{
	}
}
