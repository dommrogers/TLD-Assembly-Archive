using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootstepTrail
{
	private const float MIN_FADED_DEPTH_SCALAR = 0.025f;

	public bool m_IsOpen;

	public FootstepTrailType m_TrailType;

	public SnowImprintType m_ImprintType;

	public SnowImprintDef m_ImprintDef;

	public SnowImprintQualitySettings m_ImprintQualityDef;

	private Stack<int> m_FootstepFreeBlocks;

	private List<FootstepGroup> m_FootstepGroups;

	private List<SnowImprint> m_Footsteps;

	private bool m_RequireFadeIn;

	private Vector3 m_FadingInBasePos;

	private bool m_FadingIn;

	public List<SnowDepthTriggerRecord> m_SnowDepthTriggerRecords;

	public float m_LastFootprintDepthFrac;

	public float m_LastFootprintDepth;

	private static FootstepTrailSaveDataProxy m_FootstepTrailSaveDataProxy;

	private static FootstepGroupSaveDataProxy m_FootstepGroupSaveDataProxy;

	public List<SnowImprint> Footsteps
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public int NumGroups
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FootstepTrail()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	public FootstepTrail(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(FootstepTrail), Member = ".ctor")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CallerCount(Count = 5)]
	public void Initialize(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FootstepTrail(FootstepTrailSaveDataProxy sdp)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Destroy")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnDestroy")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Close()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnQualityChange")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallerCount(Count = 2)]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool ProcessPurge(int currCaptureTick, float currSnowDepth)
	{
		return false;
	}

	[CalledBy(Type = typeof(SnowDepth), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnPlayerEnterSnowDepthTrigger")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 34)]
	public void OnOwnerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnOwnerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "AddPlayerFootstep")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FootstepTrail), Member = "GetFootprintDepth")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(SnowImprint), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepGroup), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	public void AddFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, int variantIndex, float forceDeepFrac = 0f)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(FootstepGroup), Member = "GetFootprintIndexInTrail")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public void FadeFootprintsAtTrailEnd(bool atStart)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public float GetFootprintDepth(Vector3 pos, Vector3 groundNormal, float forceDeepFrac)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public FootstepGroup GetOpenFootstepGroup()
	{
		return null;
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public int ReserveFootstepBlock()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void ReturnFootstepBlock(int baseIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFootstepGroup(FootstepGroup fg)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(FootstepGroup), Member = "SerializeFootsteps")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(FootstepGroup), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(SnowImprint), Member = ".ctor")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumFootsteps()
	{
		return 0;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsVisible()
	{
		return false;
	}
}
