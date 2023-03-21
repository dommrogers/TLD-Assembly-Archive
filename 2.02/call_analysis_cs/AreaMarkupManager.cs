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

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UnreserveAreaMarkup(AreaMarkup am)
	{
	}

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsAreaMarkupReserved(AreaMarkup am)
	{
		return false;
	}

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void MaybeUnreserveAreaMarkups()
	{
	}

	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "IsAreaMarkupReserved")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void FindAllAreaMarkups(Vector3 target, AreaMarkupType amt)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "UnreserveAreaMarkup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public bool MaybeReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenWanderRegion")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenMarkupGenerator(MarkupPointGenerator mpg, string regionName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenWanderRegion(WanderRegion wanderRegion)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenSpawnRegion(SpawnRegion spawnRegion)
	{
		return null;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void FindAreaMarkupsOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, ref List<AreaMarkup> areaMarkupList)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public AreaMarkup FindRandomAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAllAreaMarkups")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public AreaMarkup FindFarthestAreaMarkupOfTypeWithinRadius(Vector3 target, AreaMarkupType amt, float radius, Vector3 pathDirection)
	{
		return null;
	}

	[CalledBy(Type = typeof(AreaMarkup), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void RegisterArea(AreaMarkup am)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UnregisterArea(AreaMarkup am)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 52)]
	public AreaMarkupManager()
	{
	}
}
