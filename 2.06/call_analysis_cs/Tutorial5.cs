using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Tutorial5 : MonoBehaviour
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void SetDurationToCurrentProgress()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Tutorial5()
	{
	}
}
