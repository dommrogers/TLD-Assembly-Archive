using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BipedSyncPoint : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BipedSyncPoint()
	{
	}
}
