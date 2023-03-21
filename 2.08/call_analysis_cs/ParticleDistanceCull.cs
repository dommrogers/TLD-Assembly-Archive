using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleDistanceCull : MonoBehaviour
{
	public enum ParticleGatherType
	{
		Manual,
		OnLoad
	}

	[Serializable]
	private struct ParticleDef
	{
		public ParticleSystem m_Particle;

		public ParticleSystem.MinMaxGradient m_StartColor;
	}

	public float m_LowDistance;

	public float m_MediumDistance;

	public float m_HighDistance;

	public float m_UltraDistance;

	public float m_FadePercentage;

	public float m_UpdateFrequency;

	public ParticleGatherType m_GatherType;

	public List<ParticleSystem> m_ParticleList;

	private List<ParticleDef> m_ParticleDef;

	private float m_UpdateTime;

	private float m_MaxDistSqr;

	private float m_FadeDistSqr;

	private QualityLodBias m_CachedQuality;

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ParticleDistanceCull), Member = "UpdateParticle")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(ParticleDistanceCull), Member = "UpdateQualityValues")]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	private void UpdateQualityValues()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float DistanceToPlayer(Vector3 fxPos, Vector3 camPos)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateParticle()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleDistanceCull()
	{
	}
}
