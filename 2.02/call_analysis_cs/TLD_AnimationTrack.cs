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

		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 9)]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
		public void CopyFrom(Rigidbody rb)
		{
		}

		[CallerCount(Count = 52)]
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
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "UpdateComponentStates")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	[CallsUnknownMethods(Count = 3)]
	public void Play()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
	[Calls(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "UpdateComponentStates")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LateUpdatePlay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "SaveAndDisablePhysicComponents")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "RestorePhysicComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableSavedPhysicColliders(GameObject gameObject, bool isEnabled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyFrom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Play")]
	[CallsUnknownMethods(Count = 14)]
	private void SaveAndDisablePhysicComponents(GameObject go)
	{
	}

	[Calls(Type = typeof(RigidBodyInfo), Member = "CopyTo")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_AnimationTrack), Member = "EnableSavedPhysicColliders")]
	private void RestorePhysicComponents(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public TLD_AnimationTrack()
	{
	}
}
