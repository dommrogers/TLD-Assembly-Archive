using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class FootstepTrailManager : MonoBehaviour
{
	public bool m_DebugShowBounds;

	public float m_CameraCaptureBoundsSize;

	public float m_CameraCaptureHideDistance;

	public float m_DepthNoiseScalar;

	public float m_GlobalDepthScalar;

	public float m_MinGroundNormalYForPlacement;

	public SnowImprintDef[] m_ImprintDefs;

	public FootstepTrail m_ActivePlayerTrail;

	public float m_MinInitialSnowDepthOnDeserialize;

	private OctreeBounds<FootstepGroup> m_FootstepGroupOctree;

	private List<FootstepTrail> m_Trails;

	private List<FootstepGroup>[] m_CaptureLists;

	private List<FootstepGroup> m_OpenFootstepGroups;

	private int m_CaptureTick;

	private FootStepGroupDistanceComparer m_DistanceComparer;

	private int m_TrailPurgeIndex;

	private bool m_AwakeHasBeenCalled;

	public static FootstepTrailManager m_Instance;

	private static FootstepTrailManagerSaveDataProxy m_FootstepTrailManagerSaveDataProxy;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public SnowImprintDef GetImprintDef(SnowImprintType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public void AddFootstepTrail(FootstepTrail fst, bool isPlayerTrail = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAddFootstepGroup(FootstepGroup group)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnCloseFootstepGroup(FootstepGroup group)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnRemoveFootstepGroup(FootstepGroup group)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(FootstepTrail), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FootstepTrail), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	public void AddPlayerFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, float forceDeepFrac)
	{
	}

	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerEnterSnowDepthTrigger")]
	[CallerCount(Count = 0)]
	public void OnPlayerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerExitSnowDepthTrigger")]
	[CallerCount(Count = 0)]
	public void OnPlayerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public bool IsFootprintPositionValid(Vector3 heelPos, Vector3 offset, float footLen, out Vector3 point, out Vector3 normal)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref point) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref normal) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FootstepTrailManager()
	{
	}
}
