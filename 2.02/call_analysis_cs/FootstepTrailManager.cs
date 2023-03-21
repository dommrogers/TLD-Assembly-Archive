using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 52)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public SnowImprintDef GetImprintDef(SnowImprintType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	public void AddFootstepTrail(FootstepTrail fst, bool isPlayerTrail = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void OnAddFootstepGroup(FootstepGroup group)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void OnCloseFootstepGroup(FootstepGroup group)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void OnRemoveFootstepGroup(FootstepGroup group)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FootstepTrail), Member = "Serialize")]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Awake")]
	[Calls(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 25)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public void OnPlayerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public bool IsFootprintPositionValid(Vector3 heelPos, Vector3 offset, float footLen, out Vector3 point, out Vector3 normal)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref point) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref normal) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(FootstepGroup), Member = "Show")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FootstepTrailManager()
	{
	}
}
