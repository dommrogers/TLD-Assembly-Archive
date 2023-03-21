using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Breath : MonoBehaviour
{
	[Serializable]
	private class PickupIntensityAudio
	{
		public AK.Wwise.Event m_Low;

		public AK.Wwise.Event m_Medium;

		public AK.Wwise.Event m_High;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PickupIntensityAudio()
		{
		}
	}

	[Serializable]
	private class HeavyBreathingAudio
	{
		public AK.Wwise.Event m_Light;

		public AK.Wwise.Event m_Medium;

		public AK.Wwise.Event m_Heavy;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public HeavyBreathingAudio()
		{
		}
	}

	public float m_NormalBreathSeconds;

	public float m_HeavyBreathSeconds;

	public float m_ColdBreathTempThreshold;

	public float m_VeryColdBreathTempThreshold;

	public float m_FreezingBreathTempThreshold;

	public GameObject m_BreathColdPrefab;

	public GameObject m_BreathVeryColdPrefab;

	public GameObject m_BreathFreezingPrefab;

	private AK.Wwise.Event m_TooInjuredToSprintAudio;

	private PickupIntensityAudio m_PickupIntensityAudio;

	private HeavyBreathingAudio m_HeavyBreathingAudio;

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

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	public void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallsUnknownMethods(Count = 4)]
	public void StopBreathEffectImmediate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetBreathTimePercent()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[Calls(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 10)]
	private void PlayBreathEffect()
	{
	}

	[CallerCount(Count = 0)]
	public static float GetBreathingStatePercent(HeavyBreathingState hbs)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[Calls(Type = typeof(Breath), Member = "ParentEffectToCamera")]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	[Calls(Type = typeof(DownsampleFX), Member = "RegisterParticleSystem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	private void ParentEffectToCamera(GameObject instance)
	{
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "ShouldSupressBreathFX")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	private bool ShouldSuppressBreathEffect()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Breath()
	{
	}
}
