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

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(vp_Shell), Member = "DecideRestAngle")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_Shell), Member = "Update")]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	protected void DecideRestAngle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 13)]
	protected void UpRight()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 12)]
	protected void TippedOver()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_Shell()
	{
	}
}
