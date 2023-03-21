using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootstepGroup
{
	public const int FOOTSTEP_BLOCK_SIZE_SHIFT = 4;

	public const int FOOTSTEP_BLOCK_SIZE = 16;

	public const int FOOTSTEP_BLOCK_SIZE_M1 = 15;

	public const int MAX_BLOCKS_PER_GROUP = 8;

	public const int MAX_FOOTSTEPS = 128;

	public const float MAX_SNOW_DEPTH_DIFFERENCE = 0.02f;

	public Bounds m_Bounds;

	public bool m_IsOpen;

	public int m_NumFootsteps;

	public int m_LastVisibleImprint;

	public float m_BaseSnowDepth;

	public float m_ExpireSnowDepth;

	private FootstepTrail m_Parent;

	private int[] m_FootstepBlockBases;

	public int m_CaptureTick;

	private HashSet<int> m_ReferencedSnowPatches;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public FootstepGroup(FootstepTrail parent, Vector3 pos, Vector3 defaultBoundsSize)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "ProcessPurge")]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void Close()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 1)]
	public bool MaybeAddFootstep(Vector3 pos, ref SnowImprint footstep, float depth, Vector3 defaultBoundsSize, Vector3 boundsLimit)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	public void AddFootstep(ref SnowImprint footstep, float depth)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 3)]
	public void AddFootstep(ref SnowImprint footstep)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateExpireDepth(float depth)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[CallerCount(Count = 2)]
	public void Show(int captureTick)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetFootprintIndexInTrail(int i)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void SerializeFootsteps(List<uint> list)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AdjustSnowDepthRecords")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Hide")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Destroy")]
	private void RemovePatchRefs()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool QualityAllowsShowing()
	{
		return default(bool);
	}
}
