using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIVisibility : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MakeVisible()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MakeInvisible()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIVisibility()
	{
	}
}
