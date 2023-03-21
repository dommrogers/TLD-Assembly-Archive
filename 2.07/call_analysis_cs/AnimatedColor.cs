using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AnimatedColor()
	{
	}
}
