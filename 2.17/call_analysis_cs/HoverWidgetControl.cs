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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDragOut()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HoverWidgetControl()
	{
	}
}
