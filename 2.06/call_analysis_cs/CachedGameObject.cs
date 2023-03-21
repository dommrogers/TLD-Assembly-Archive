using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObject : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CachedGameObject()
	{
	}
}
