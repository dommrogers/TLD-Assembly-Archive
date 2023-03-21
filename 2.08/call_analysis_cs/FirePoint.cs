using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
	public float m_Intensity;

	public bool m_LightSelf;

	public float m_LightRange;

	public float m_LightMinimum;

	public float m_LightMaximum;

	public float m_LightIntervalSeconds;

	public GameObject m_SmokeParticles;

	public GameObject m_SparkParticles;

	public GameObject m_SpriteParticles;

	public GameObject m_Lights;

	private List<LightRandomIntensity> m_ChildLightRandomIntensityList;

	private List<Light> m_ChildLightList;

	private ParticleSystem m_SpriteParticlesPS;

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(FirePoint), Member = "StartFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(FirePoint), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	private void StartFire()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[CalledBy(Type = typeof(FirePoint), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FirePoint), Member = "Start")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	private void UpdateRatesAndSizes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public FirePoint()
	{
	}
}
