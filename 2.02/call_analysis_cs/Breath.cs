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

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void StopBreathEffectImmediate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBreathTimePercent()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	private void PlayBreathEffect()
	{
	}

	[CallerCount(Count = 0)]
	public static float GetBreathingStatePercent(HeavyBreathingState hbs)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	private void ParentEffectToCamera(GameObject instance)
	{
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private bool ShouldSuppressBreathEffect()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Breath()
	{
	}
}
