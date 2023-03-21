using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlowingWater : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FlowingWater()
	{
	}
}
