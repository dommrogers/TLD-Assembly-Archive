using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleRandomEmission : MonoBehaviour
{
	public float m_IntervalSeconds;

	public float m_Min;

	public float m_Max;

	public float m_CurrentEmissionRate;

	private float m_CurrentTime;

	private float m_Destination;

	private float m_EmissionStart;

	private ParticleSystem m_ParticleSystem;

	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetEmissonRate(ParticleSystem ps, float newRate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ForceEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParticleRandomEmission()
	{
	}
}
