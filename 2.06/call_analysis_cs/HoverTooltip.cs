using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HoverTooltip : MonoBehaviour
{
	public UIWidget m_TooltipWidget;

	public float m_HoverTimeRequiredSecs;

	public float m_FadeInTimeSecs;

	public float m_FadeOutTimeSecs;

	private UIWidget m_Widget;

	private bool m_IsHovering;

	private float m_StartHoverTime;

	private float m_EndHoverTime;

	private float m_AlphaOnEndHover;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnHover(bool hover)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HoverTooltip()
	{
	}
}
