using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Tutorial5 : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetDurationToCurrentProgress()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Tutorial5()
	{
	}
}
