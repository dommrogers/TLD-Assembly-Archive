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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[Calls(Type = typeof(FirePoint), Member = "StartFire")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(FirePoint), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void StartFire()
	{
	}

	[CalledBy(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[CalledBy(Type = typeof(FirePoint), Member = "Start")]
	[CalledBy(Type = typeof(FirePoint), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FirePoint), Member = "SetEmissionRate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateRatesAndSizes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirePoint), Member = "UpdateRatesAndSizes")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public FirePoint()
	{
	}
}
