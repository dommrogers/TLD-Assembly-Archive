using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CachedGameObjectExclude : MonoBehaviour
{
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CachedGameObjectExclude()
	{
	}
}
