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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "InitializeIfNeeded")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeMovementInEmitterSpace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeIfNeeded()
	{
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private Vector3 ComputeMovementInEmitterSpace(Transform worldSpace)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	private Vector3 ComputeWindInEmitterSpace()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public FirstPersonParticles()
	{
	}
}
