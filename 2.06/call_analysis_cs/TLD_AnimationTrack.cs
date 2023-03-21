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

		[CallerCount(Count = 98)]
		[DeduplicatedMethod]
		public GameObject GetOwner()
		{
			return null;
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 6)]
		[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
		[CallsUnknownMethods(Count = 8)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LateUpdatePlay()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableSavedPhysicColliders(GameObject gameObject, bool isEnabled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyFrom")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Play")]
	[CallsUnknownMethods(Count = 8)]
	private void SaveAndDisablePhysicComponents(GameObject go)
	{
	}

	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Stop")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyTo")]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RestorePhysicComponents(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public TLD_AnimationTrack()
	{
	}
}
