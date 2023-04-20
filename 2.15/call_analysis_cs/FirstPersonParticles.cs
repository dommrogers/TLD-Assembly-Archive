using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstPersonParticles : MonoBehaviour
{
	private bool m_ApplyPlayerMovement;

	private float m_PlayerMovementScale;

	private bool m_ApplyWindForce;

	private bool m_IgnoreOcclusion;

	private float m_OcclusionPollIntervalSeconds;

	private float m_WindForceScale;

	private Vector3 m_LastFrameWorldPosition;

	private bool m_AppliedLastFrame;

	private float m_CurrentTime;

	private ParticleSystem m_System;

	private ParticleSystem.Particle[] m_Particles;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeMovementInEmitterSpace")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "InitializeIfNeeded")]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeIfNeeded()
	{
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 ComputeMovementInEmitterSpace(Transform worldSpace)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 ComputeWindInEmitterSpace()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public FirstPersonParticles()
	{
	}
}
