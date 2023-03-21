using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIVisibility : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void MakeVisible()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void MakeInvisible()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIVisibility()
	{
	}
}
