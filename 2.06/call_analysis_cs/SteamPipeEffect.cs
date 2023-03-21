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

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "OnDestroy")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Start")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public void SetSource(SteamPipe source)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateHeatTime")]
	[CalledBy(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsUnknownMethods(Count = 2)]
	public void Thaw(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFrozen()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateParticles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateRenderers")]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(SteamPipeEffect), Member = "SetSource")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateRenderers")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "UpdateParticles")]
	public void DoUpdate(float currentTime)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnPipeSourceInternalFlowChanged(float value)
	{
	}

	[CalledBy(Type = typeof(SteamPipeEffect), Member = "Thaw")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateHeatTime()
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 0)]
	private bool MaybeUpdateThawing(float currentTime)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
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
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "PlayOrStopAudio")]
	private void MaybePlayHeatingAudio(bool isHeatChanging)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "MaybePlayThawingAudio")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "MaybePlayHeatingAudio")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "MaybePlayHeatingAudio")]
	private void PlayOrStopAudio(bool shouldPlay, string audio, ref uint audioID)
	{
	}

	[CalledBy(Type = typeof(SteamPipeEffect), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateParticles()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipeEffect()
	{
	}
}
