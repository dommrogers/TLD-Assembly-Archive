using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AnimatedColor()
	{
	}
}
