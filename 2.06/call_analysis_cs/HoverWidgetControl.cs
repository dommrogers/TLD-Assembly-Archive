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

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnHover(bool isHovering)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDragOut()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HoverWidgetControl()
	{
	}
}
