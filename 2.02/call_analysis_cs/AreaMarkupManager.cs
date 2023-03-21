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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	private void UnreserveAreaMarkup(AreaMarkup am)
	{
	}

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	private bool IsAreaMarkupReserved(AreaMarkup am)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	private void MaybeUnreserveAreaMarkups()
	{
	}

	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	private void FindAllAreaMarkups(Vector3 target, AreaMarkupType amt)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	public bool MaybeReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenWanderRegion")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[CallsUnknownMethods(Count = 6)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenMarkupGenerator(MarkupPointGenerator mpg, string regionName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenWanderRegion(WanderRegion wanderRegion)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CallsUnknownMethods(Count = 1)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenSpawnRegion(SpawnRegion spawnRegion)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	public void FindAreaMarkupsOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, ref List<AreaMarkup> areaMarkupList)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CallsUnknownMethods(Count = 11)]
	public AreaMarkup FindRandomAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public AreaMarkup FindFarthestAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, Vector3 pathDirection)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AreaMarkup), Member = "Start")]
	public void RegisterArea(AreaMarkup am)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void UnregisterArea(AreaMarkup am)
	{
	}

	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 52)]
	public AreaMarkupManager()
	{
	}
}
