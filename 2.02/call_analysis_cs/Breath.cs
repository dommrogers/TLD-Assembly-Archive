using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Breath : MonoBehaviour
{
	public float m_NormalBreathSeconds;

	public float m_HeavyBreathSeconds;

	public float m_ColdBreathTempThreshold;

	public float m_VeryColdBreathTempThreshold;

	public float m_FreezingBreathTempThreshold;

	public GameObject m_BreathColdPrefab;

	public GameObject m_BreathVeryColdPrefab;

	public GameObject m_BreathFreezingPrefab;

	private GameObject m_BreathCold;

	private GameObject m_BreathVeryCold;

	private GameObject m_BreathFreezing;

	private ParticleSystem m_BreathColdParticleSystem;

	private ParticleSystem m_BreathVeryColdParticleSystem;

	private ParticleSystem m_BreathFreezingParticleSystem;

	private float m_NextBreathTime;

	private bool m_EffectsParented;

	private float m_BreathTimePercent;

	private float m_BreathTime;

	public bool m_SuppressEffects;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 33)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void StopBreathEffectImmediate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBreathTimePercent()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	private void PlayBreathEffect()
	{
	}

	[CallerCount(Count = 0)]
	public static float GetBreathingStatePercent(HeavyBreathingState hbs)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 24)]
	private void ParentEffectToCamera(GameObject instance)
	{
	}

	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private bool ShouldSuppressBreathEffect()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Breath()
	{
	}
}
