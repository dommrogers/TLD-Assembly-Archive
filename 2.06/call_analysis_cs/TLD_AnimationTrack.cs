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

		[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 9)]
		public void CopyFrom(Rigidbody rb)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 113)]
		public GameObject GetOwner()
		{
			return null;
		}

		[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 6)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LateUpdatePlay()
	{
	}

	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableSavedPhysicColliders(GameObject gameObject, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyFrom")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void SaveAndDisablePhysicComponents(GameObject go)
	{
	}

	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Stop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyTo")]
	[CallsUnknownMethods(Count = 4)]
	private void RestorePhysicComponents(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public TLD_AnimationTrack()
	{
	}
}
