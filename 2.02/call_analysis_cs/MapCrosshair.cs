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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "ResetToNormal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	public void ResetToNormal()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public void SetState(CrosshairState newState)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MapCrosshair()
	{
	}
}
