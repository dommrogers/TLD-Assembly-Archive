using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleWindForce : MonoBehaviour
{
	public bool m_EnableForcesByDefault;

	public bool m_IgnoreOcculsion;

	public bool m_ExternalOcclusionTest;

	public float m_OcclusionPollIntervalSeconds;

	public OcclusionTest m_OcclusionTest;

	private ParticleSystem m_myPS;

	private ParticleSystem.ExternalForcesModule m_externalForces;

	private float m_CurrentTime;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleWindForce()
	{
	}
}
