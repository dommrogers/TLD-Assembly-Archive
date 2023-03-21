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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(FirstPersonParticles), Member = "InitializeIfNeeded")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[Calls(Type = typeof(ParticleSystem), Member = "SetParticles")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeMovementInEmitterSpace")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeIfNeeded()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private Vector3 ComputeMovementInEmitterSpace(Transform worldSpace)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	private Vector3 ComputeWindInEmitterSpace()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public FirstPersonParticles()
	{
	}
}
