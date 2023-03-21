using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AnimatedColor()
	{
	}
}
