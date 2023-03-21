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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ParticleDistanceCull), Member = "UpdateParticle")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(ParticleDistanceCull), Member = "UpdateQualityValues")]
	[CallsUnknownMethods(Count = 3)]
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
		return 0f;
	}

	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateParticle()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleDistanceCull()
	{
	}
}
