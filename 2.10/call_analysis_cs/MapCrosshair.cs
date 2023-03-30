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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public void ResetToNormal()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public void SetState(CrosshairState newState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MapCrosshair()
	{
	}
}
