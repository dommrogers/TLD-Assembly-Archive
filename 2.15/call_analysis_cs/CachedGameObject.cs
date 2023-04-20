using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObject : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CachedGameObject()
	{
	}
}
