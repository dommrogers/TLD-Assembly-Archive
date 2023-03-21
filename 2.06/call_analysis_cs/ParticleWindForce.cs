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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleWindForce()
	{
	}
}
