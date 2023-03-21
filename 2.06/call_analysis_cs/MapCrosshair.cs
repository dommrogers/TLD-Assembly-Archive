using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapCrosshair : MonoBehaviour
{
	public enum CrosshairState
	{
		Normal,
		NormalHoverSmall,
		NormalHoverBig,
		NormalHoverArea,
		Zoom,
		ZoomHoverSmall,
		ZoomHoverBig,
		ZoomHoverArea
	}

	public float m_SpacingNormal;

	public float m_SpacingHoverSmall;

	public float m_SpacingHoverBig;

	public float m_SpacingHoverArea;

	public Transform m_SpriteLeft;

	public Transform m_SpriteRight;

	public Transform m_SpriteUp;

	public Transform m_SpriteDown;

	public float m_ScaleBegin;

	public float m_ScaleEnd;

	private CrosshairState m_State;

	private TweenScale m_TweenScaleLeft;

	private TweenScale m_TweenScaleRight;

	private TweenScale m_TweenScaleUp;

	private TweenScale m_TweenScaleDown;

	private TweenPosition m_TweenPosLeft;

	private TweenPosition m_TweenPosRight;

	private TweenPosition m_TweenPosUp;

	private TweenPosition m_TweenPosDown;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallsUnknownMethods(Count = 9)]
	public void ResetToNormal()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 2)]
	public void SetState(CrosshairState newState)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public MapCrosshair()
	{
	}
}
