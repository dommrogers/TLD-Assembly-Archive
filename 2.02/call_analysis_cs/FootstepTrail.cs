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
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FootstepTrail()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	public FootstepTrail(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(FootstepTrail), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[CallAnalysisFailed]
	public void Initialize(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FootstepTrail(FootstepTrailSaveDataProxy sdp)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Destroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	public void Destroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnQualityChange")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public bool ProcessPurge(int currCaptureTick, float currSnowDepth)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnPlayerEnterSnowDepthTrigger")]
	[CalledBy(Type = typeof(SnowDepth), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void OnOwnerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public void OnOwnerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(FootstepGroup), Member = ".ctor")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "AddPlayerFootstep")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(SnowImprint), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(FootstepTrail), Member = "GetFootprintDepth")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	public void AddFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, int variantIndex, float forceDeepFrac = 0f)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	public void FadeFootprintsAtTrailEnd(bool atStart)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	public float GetFootprintDepth(Vector3 pos, Vector3 groundNormal, float forceDeepFrac)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FootstepGroup GetOpenFootstepGroup()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 11)]
	public int ReserveFootstepBlock()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ReturnFootstepBlock(int baseIndex)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemoveFootstepGroup(FootstepGroup fg)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(FootstepGroup), Member = "SerializeFootsteps")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SnowImprint), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = ".ctor")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetNumFootsteps()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	public bool IsVisible()
	{
		return default(bool);
	}
}
