using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.DebugTools;

public class ConditionMonitor : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ConditionMonitor()
	{
	}
}
