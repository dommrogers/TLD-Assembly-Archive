using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlowingWater : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FlowingWater()
	{
	}
}
