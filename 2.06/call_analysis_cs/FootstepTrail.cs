using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	public int NumGroups
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FootstepTrail()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	public FootstepTrail(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CalledBy(Type = typeof(FootstepTrail), Member = ".ctor")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallAnalysisFailed]
	public void Initialize(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FootstepTrail(FootstepTrailSaveDataProxy sdp)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnDestroy")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Destroy")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	public void Destroy()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnQualityChange")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessPurge(int currCaptureTick, float currSnowDepth)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(SnowDepth), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "OnPlayerEnterSnowDepthTrigger")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void OnOwnerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void OnOwnerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "AddPlayerFootstep")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "Destroy")]
	[Calls(Type = typeof(FootstepGroup), Member = ".ctor")]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[Calls(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	[Calls(Type = typeof(SnowImprint), Member = ".ctor")]
	[Calls(Type = typeof(FootstepTrail), Member = "GetFootprintDepth")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	public void AddFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, int variantIndex, float forceDeepFrac = 0f)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[CallerCount(Count = 4)]
	public void FadeFootprintsAtTrailEnd(bool atStart)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFootprintDepth(Vector3 pos, Vector3 groundNormal, float forceDeepFrac)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	public FootstepGroup GetOpenFootstepGroup()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 2)]
	public int ReserveFootstepBlock()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ReturnFootstepBlock(int baseIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveFootstepGroup(FootstepGroup fg)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "AddForSerialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(FootstepGroup), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SnowImprint), Member = ".ctor")]
	[Calls(Type = typeof(FootstepGroup), Member = ".ctor")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	public int GetNumFootsteps()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleFootprintsForDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HandleFootprintsForDespawn")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsVisible()
	{
		return default(bool);
	}
}
