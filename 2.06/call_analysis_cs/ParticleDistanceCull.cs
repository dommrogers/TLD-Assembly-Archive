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

	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	private void Start()
	{
	}

	[Calls(Type = typeof(ParticleDistanceCull), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleDistanceCull), Member = "UpdateParticle")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	private void UpdateQualityValues()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float DistanceToPlayer(Vector3 fxPos, Vector3 camPos)
	{
		return default(float);
	}

	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateParticle()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleDistanceCull()
	{
	}
}
