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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(vp_Shell), Member = "DecideRestAngle")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 10)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(vp_Shell), Member = "Update")]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	protected void DecideRestAngle()
	{
	}

	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	protected void UpRight()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 12)]
	protected void TippedOver()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public vp_Shell()
	{
	}
}
