using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObject : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CachedGameObject()
	{
	}
}
