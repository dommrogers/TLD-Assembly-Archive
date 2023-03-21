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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeMovementInEmitterSpace")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[Calls(Type = typeof(FirstPersonParticles), Member = "InitializeIfNeeded")]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles")]
	[Calls(Type = typeof(ParticleSystem), Member = "SetParticles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeIfNeeded()
	{
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private Vector3 ComputeMovementInEmitterSpace(Transform worldSpace)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(FirstPersonParticles), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 ComputeWindInEmitterSpace()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public FirstPersonParticles()
	{
	}
}
