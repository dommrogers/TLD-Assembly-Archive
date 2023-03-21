using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SequelMissionUILock : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SequelMissionUILock()
	{
	}
}
