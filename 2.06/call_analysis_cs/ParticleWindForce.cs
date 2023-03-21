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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleWindForce()
	{
	}
}
