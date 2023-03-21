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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(PlayerStunned), Member = "End")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStunned), Member = "End")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsStunned()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_player_stunned")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CallsUnknownMethods(Count = 12)]
	public void Begin(float stunnedDurationSeconds, float stunnedTransitionSeconds = 1f)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void End()
	{
	}

	[CallsUnknownMethods(Count = 70)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "Update")]
	[Calls(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateBlurEffect()
	{
	}

	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSController), Member = "AddForce")]
	private void UpdateLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerStunned()
	{
	}
}
