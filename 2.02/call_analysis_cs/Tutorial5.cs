using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Tutorial5 : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void SetDurationToCurrentProgress()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Tutorial5()
	{
	}
}
