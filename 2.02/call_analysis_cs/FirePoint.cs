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

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(FirePoint), Member = "StartFire")]
	[Calls(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(FirePoint), Member = "Start")]
	[CallsUnknownMethods(Count = 11)]
	private void StartFire()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(FirePoint), Member = "Update")]
	[CalledBy(Type = typeof(FirePoint), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	private void UpdateRatesAndSizes()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public FirePoint()
	{
	}
}
