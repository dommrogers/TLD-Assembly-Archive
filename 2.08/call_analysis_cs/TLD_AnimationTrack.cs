using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_AnimationTrack : AnimationTrack, TLD_IDynamicBindableTrack, TLD_ITrack
{
	private class RigidBodyInfo
	{
		private GameObject m_GameObjectOwner;

		private bool m_IsKinematic;

		private bool m_UseGravity;

		private float m_Mass;

		private float m_Drag;

		private float m_AngularDrag;

		private RigidbodyInterpolation m_Interpolation;

		private CollisionDetectionMode m_CollisionDetectionMode;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
		[CallsUnknownMethods(Count = 9)]
		public void CopyFrom(Rigidbody rb)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		public GameObject GetOwner()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 6)]
		public void CopyTo(Rigidbody rb)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public RigidBodyInfo()
		{
		}
	}

	public string m_MissionObjectId;

	public string m_ChildObjectName;

	public bool m_DisablePhysics;

	private Collider[] m_SavedColliders;

	private List<RigidBodyInfo> m_SavedRigidBodyInfoList;

	private GameObject m_DynamicBinding;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdatePlay()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void LateUpdatePlay()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableSavedPhysicColliders(GameObject gameObject, bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Play")]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyFrom")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	private void SaveAndDisablePhysicComponents(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyTo")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Stop")]
	private void RestorePhysicComponents(GameObject go)
	{
	}

	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TLD_AnimationTrack()
	{
	}
}
