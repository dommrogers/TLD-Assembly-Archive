using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HoverWidgetControl : MonoBehaviour
{
	public UIWidget m_WidgetToEnableOnHover;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnHover(bool isHovering)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDragOut()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HoverWidgetControl()
	{
	}
}
