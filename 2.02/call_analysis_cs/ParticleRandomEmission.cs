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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Random), Member = "Range")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ParticleRandomEmission()
	{
	}
}
