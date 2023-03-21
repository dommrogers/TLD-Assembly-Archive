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

	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OctreeBounds<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public FootstepGroup(FootstepTrail parent, Vector3 pos, Vector3 defaultBoundsSize)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Reset")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "ProcessPurge")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Close")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(OctreeBounds<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool MaybeAddFootstep(Vector3 pos, ref SnowImprint footstep, float depth, Vector3 defaultBoundsSize, Vector3 boundsLimit)
	{
		return false;
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "MaybeAddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddFootstep(ref SnowImprint footstep, float depth)
	{
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "AddFootstep")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FootstepTrail), Member = "ReserveFootstepBlock")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void AddFootstep(ref SnowImprint footstep)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateExpireDepth(float depth)
	{
	}

	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public void Show(int captureTick)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepGroup), Member = "RemovePatchRefs")]
	public void Hide()
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int GetFootprintIndexInTrail(int i)
	{
		return 0;
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "AddForSerialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void SerializeFootsteps(List<uint> list)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "AdjustSnowDepthRecords")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowImprint), Member = "set_InitialSnowDepth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "Destroy")]
	[CalledBy(Type = typeof(FootstepGroup), Member = "Hide")]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SnowPatchManager), Member = "RemovePatchRef")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RemovePatchRefs()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool QualityAllowsShowing()
	{
		return false;
	}
}
