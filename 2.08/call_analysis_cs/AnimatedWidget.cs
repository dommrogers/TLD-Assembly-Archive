using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedWidget : MonoBehaviour
{
	public float width;

	public float height;

	private UIWidget mWidget;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public AnimatedWidget()
	{
	}
}
