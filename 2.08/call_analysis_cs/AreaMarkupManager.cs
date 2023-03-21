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

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void UnreserveAreaMarkup(AreaMarkup am)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsAreaMarkupReserved(AreaMarkup am)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	private void MaybeUnreserveAreaMarkups()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	private void FindAllAreaMarkups(Vector3 target, AreaMarkupType amt)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	public bool MaybeReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenWanderRegion")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenMarkupGenerator(MarkupPointGenerator mpg, string regionName)
	{
		return null;
	}

	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenWanderRegion(WanderRegion wanderRegion)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenSpawnRegion(SpawnRegion spawnRegion)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CallsUnknownMethods(Count = 9)]
	public void FindAreaMarkupsOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, ref List<AreaMarkup> areaMarkupList)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallsUnknownMethods(Count = 11)]
	public AreaMarkup FindRandomAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	public AreaMarkup FindFarthestAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, Vector3 pathDirection)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public AreaMarkupManager()
	{
	}
}
