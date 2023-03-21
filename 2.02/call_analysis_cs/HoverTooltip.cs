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

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public HoverTooltip()
	{
	}
}
