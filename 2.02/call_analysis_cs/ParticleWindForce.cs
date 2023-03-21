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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ParticleWindForce()
	{
	}
}
