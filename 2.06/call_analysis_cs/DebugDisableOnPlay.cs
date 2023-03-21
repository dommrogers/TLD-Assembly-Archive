using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugDisableOnPlay : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DebugDisableOnPlay()
	{
	}
}
