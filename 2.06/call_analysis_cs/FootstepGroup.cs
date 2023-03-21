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
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public FootstepGroup(FootstepTrail parent, Vector3 pos, Vector3 defaultBoundsSize)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "ProcessPurge")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	public void Destroy()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Close")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Close()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	public bool MaybeAddFootstep(Vector3 pos, ref SnowImprint footstep, float depth, Vector3 defaultBoundsSize, Vector3 boundsLimit)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 1)]
	public void AddFootstep(ref SnowImprint footstep, float depth)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepTrail), Member = "ReserveFootstepBlock")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void AddFootstep(ref SnowImprint footstep)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateExpireDepth(float depth)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowPatchManager), Member = "AddImprint")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowImprint), Member = "AddForSerialize")]
	[CallsUnknownMethods(Count = 2)]
	public void SerializeFootsteps(List<uint> list)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AdjustSnowDepthRecords")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Destroy")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Hide")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 25)]
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
