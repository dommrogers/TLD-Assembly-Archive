using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BipedSyncPoint : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BipedSyncPoint()
	{
	}
}
