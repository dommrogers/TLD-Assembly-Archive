using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AreaMarkupManager : MonoBehaviour
{
	public static float DefaultSearchRadius;

	private List<AreaMarkup> m_AreaMarkupList;

	private Dictionary<MarkupPointGenerator, List<AreaMarkup>> m_AreaMarkupByGenerator;

	private List<AreaMarkup> m_TestAreaMarkupList;

	private List<AreaMarkup> m_TmpRandomAreaMarkupList;

	private List<AreaMarkup> m_RemoveList;

	private Dictionary<AreaMarkup, BaseAi> m_BaseAiReserveByAreaMarkup;

	private Dictionary<BaseAi, AreaMarkup> m_AreaMarkupReserveByBaseAi;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallsUnknownMethods(Count = 3)]
	private void UnreserveAreaMarkup(AreaMarkup am)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	private bool IsAreaMarkupReserved(AreaMarkup am)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	private void MaybeUnreserveAreaMarkups()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 9)]
	private void FindAllAreaMarkups(Vector3 target, AreaMarkupType amt)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	public bool MaybeReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenWanderRegion")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[CallsUnknownMethods(Count = 3)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenMarkupGenerator(MarkupPointGenerator mpg, string regionName)
	{
		return null;
	}

	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenWanderRegion(WanderRegion wanderRegion)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CallsUnknownMethods(Count = 1)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenSpawnRegion(SpawnRegion spawnRegion)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CallsUnknownMethods(Count = 9)]
	public void FindAreaMarkupsOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, ref List<AreaMarkup> areaMarkupList)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallerCount(Count = 1)]
	public AreaMarkup FindRandomAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CallsUnknownMethods(Count = 6)]
	public AreaMarkup FindFarthestAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, Vector3 pathDirection)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AreaMarkup), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RegisterArea(AreaMarkup am)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterArea(AreaMarkup am)
	{
	}

	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public AreaMarkupManager()
	{
	}
}
