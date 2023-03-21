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
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	public FootstepGroup(FootstepTrail parent, Vector3 pos, Vector3 defaultBoundsSize)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Reset")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "ProcessPurge")]
	[CallsDeduplicatedMethods(Count = 10)]
	public void Destroy()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Close")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void Close()
	{
	}

	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	public bool MaybeAddFootstep(Vector3 pos, ref SnowImprint footstep, float depth, Vector3 defaultBoundsSize, Vector3 boundsLimit)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	public void AddFootstep(ref SnowImprint footstep, float depth)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FootstepTrail), Member = "ReserveFootstepBlock")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 12)]
	public void AddFootstep(ref SnowImprint footstep)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void UpdateExpireDepth(float depth)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 18)]
	public void Show(int captureTick)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public int GetFootprintIndexInTrail(int i)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "AddForSerialize")]
	public void SerializeFootsteps(List<uint> list)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AdjustSnowDepthRecords")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "set_InitialSnowDepth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowPatchManager), Member = "RemovePatchRef")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Destroy")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Hide")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 5)]
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
