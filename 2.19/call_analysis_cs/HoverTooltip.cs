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
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnHover(bool hover)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HoverTooltip()
	{
	}
}
