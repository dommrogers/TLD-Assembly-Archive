using System;
using System.Collections.Generic;
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OctreeBounds<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddFootstepTrail(FootstepTrail fst, bool isPlayerTrail = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OctreeBounds<>), Member = "Add")]
	[CallsUnknownMethods(Count = 2)]
	public void OnAddFootstepGroup(FootstepGroup group)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(OctreeBounds<>), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCloseFootstepGroup(FootstepGroup group)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnRemoveFootstepGroup(FootstepGroup group)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(FootstepTrail), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Awake")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	public void AddPlayerFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, float forceDeepFrac)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerEnterSnowDepthTrigger")]
	public void OnPlayerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerExitSnowDepthTrigger")]
	public void OnPlayerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsFootprintPositionValid(Vector3 heelPos, Vector3 offset, float footLen, out Vector3 point, out Vector3 normal)
	{
		point = default(Vector3);
		normal = default(Vector3);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FootstepTrailManager()
	{
	}
}
