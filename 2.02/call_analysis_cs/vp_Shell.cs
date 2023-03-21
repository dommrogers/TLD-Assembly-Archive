using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_Shell : MonoBehaviour
{
	public delegate void RestAngleFunc();

	public float LifeTime;

	protected float m_RemoveTime;

	public float m_Persistence;

	protected RestAngleFunc m_RestAngleFunc;

	protected float m_RestTime;

	public List<AudioClip> m_BounceSounds;

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Shell), Member = "DecideRestAngle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	private void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	[CalledBy(Type = typeof(vp_Shell), Member = "Update")]
	[CallsUnknownMethods(Count = 23)]
	protected void DecideRestAngle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 15)]
	protected void UpRight()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	protected void TippedOver()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public vp_Shell()
	{
	}
}
