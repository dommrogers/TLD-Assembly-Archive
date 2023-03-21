using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIVisibility : MonoBehaviour
{
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MakeVisible()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void MakeInvisible()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIVisibility()
	{
	}
}
