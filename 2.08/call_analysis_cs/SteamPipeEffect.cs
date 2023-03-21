using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SteamPipeEffect : MonoBehaviour
{
	[Serializable]
	private class ParticleParameters
	{
		public ParticleSystem m_ParticleSystem;

		public AnimationCurve m_ThawingEmissionCurve;

		public AnimationCurve m_HeatingEmissionCurve;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ParticleParameters()
		{
		}
	}

	private Renderer[] m_AffectedRenderers;

	private ParticleParameters[] m_AffectedParticles;

	private AnimationCurve m_ThawingCurve;

	private AnimationCurve m_HeatingCurve;

	private float m_ThawingTime;

	private float m_HeatingTime;

	private float m_StartingFreeze;

	private float m_StartingHeat;

	private float m_HeatSaturationThreshold;

	private float m_DistanceFactorFromHeatSource;

	private string m_ThawingAudio;

	private string m_HeatOnAudio;

	private string m_HeatOffAudio;

	private SteamPipe m_Source;

	private MaterialPropertyBlock m_PropertyBlock;

	private float m_CurrentFreeze;

	private float m_LastFreeze;

	private float m_TargetFreeze;

	private float m_ThawTimeStart;

	private float m_ThawTimeEnd;

	private float m_CurrentHeat;

	private float m_LastHeat;

	private float m_TargetHeat;

	private float m_HeatTimeStart;

	private float m_HeatTimeEnd;

	private float m_DistanceDelay;

	private uint m_ThawingAudioID;

	private uint m_HeatOnAudioID;

	private uint m_HeatOffAudioID;

	private static readonly int s_FrozenAmountShaderID;

	private static readonly int s_HeatedAmountShaderID;

	[CalledBy(Type = typeof(SteamPipe), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "OnDestroy")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	public void SetSource(SteamPipe source)
	{
	}

	[CalledBy(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateHeatTime")]
	public void Thaw(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFrozen()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateRenderers")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateParticles")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(SteamPipeEffect), Member = "SetSource")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(SteamPipeEffectManager), Member = "Update")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateParticles")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateRenderers")]
	public void DoUpdate(float currentTime)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnPipeSourceInternalFlowChanged(float value)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "Thaw")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateHeatTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private bool MaybeUpdateThawing(float currentTime)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 0)]
	private bool MaybeUpdateHeating(float currentTime)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	private void MaybePlayThawingAudio(bool isThawing)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	private void MaybePlayHeatingAudio(bool isHeatChanging)
	{
	}

	[CalledBy(Type = typeof(SteamPipeEffect), Member = "MaybePlayHeatingAudio")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "MaybePlayThawingAudio")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "MaybePlayHeatingAudio")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	private void PlayOrStopAudio(bool shouldPlay, string audio, ref uint audioID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "Awake")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private void UpdateRenderers()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	private void UpdateParticles()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipeEffect()
	{
	}
}
