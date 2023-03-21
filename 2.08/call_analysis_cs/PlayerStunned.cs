using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class PlayerStunned : MonoBehaviour
{
	public float m_BlurFraction;

	public float m_BlurNoiseStepMin;

	public float m_BlurNoiseStepMax;

	public float m_BlurMinOffsetRange;

	public float m_BlurMaxOffsetRange;

	public float m_MinScreenFadeAmount;

	public float m_MaxScreenFadeAmount;

	public float m_Blur2Min;

	public float m_Blur2Max;

	public float m_StaggerNoiseStepMin;

	public float m_StaggerNoiseStepMax;

	public float m_StaggerForward;

	public float m_StaggerSide;

	public float m_StaggerRoll;

	public float m_StaggerForwardMotionFrac;

	public float m_StaggerSideMotionFrac;

	public float m_StaggerRollMotionFrac;

	public float m_RestingPitchMin;

	public float m_RestingPitchMax;

	public float m_RestingRollMin;

	public float m_RestingRollMax;

	public float m_MaxVelocityForSpeedFracCalc;

	public float m_StaggerForceScalar;

	public float m_BlurStartVal;

	public float m_BlurMaxVal;

	public string m_PlayStunnedAudioId;

	public string m_StopStunnedAudioId;

	private Vector2 m_BlurNoisePos;

	private Vector2 m_StaggerNoisePos;

	private float m_BasePitch;

	private float m_BaseRoll;

	private float m_LastBasePitch;

	private float m_LastBaseRoll;

	private float m_LastFade;

	private float m_LastBlurAmount;

	private float m_RestingRollDirection;

	private float m_StunnedTransitionSeconds;

	private bool m_IsStunned;

	private float m_EndStunnedTime;

	private float m_StartTransitionTime;

	private float m_EndInitialTransitionTime;

	private float m_StunnedDurationSeconds;

	private MotionBlur[] m_BlurEffects;

	private static Vector2 m_NoiseStep;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(PlayerStunned), Member = "End")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsStunned()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_player_stunned")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CallsUnknownMethods(Count = 1)]
	public void Begin(float stunnedDurationSeconds, float stunnedTransitionSeconds = 1f)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "Update")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void End()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "Update")]
	[Calls(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void UpdateBlurEffect()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void UpdateLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[CallerCount(Count = 0)]
	public PlayerStunned()
	{
	}
}
