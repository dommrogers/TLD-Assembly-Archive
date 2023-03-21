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

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 39)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddFootstepTrail(FootstepTrail fst, bool isPlayerTrail = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnAddFootstepGroup(FootstepGroup group)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCloseFootstepGroup(FootstepGroup group)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnRemoveFootstepGroup(FootstepGroup group)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootstepTrail), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Awake")]
	[Calls(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallerCount(Count = 0)]
	public void AddPlayerFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, float forceDeepFrac)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerEnterSnowDepthTrigger")]
	public void OnPlayerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void OnPlayerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool IsFootprintPositionValid(Vector3 heelPos, Vector3 offset, float footLen, out Vector3 point, out Vector3 normal)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref point) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref normal) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FootstepTrailManager()
	{
	}
}
