using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class SnareItem : MonoBehaviour
{
	public GameObject m_TrapDefaultMesh;

	public GameObject m_TrapSetMesh;

	public GameObject m_TrapBrokenMesh;

	public GameObject m_TrapWithRabbitMesh;

	public GameObject m_RabbitPrefab;

	public GameObject m_RabbitSpawnPoint;

	public SnareState m_State;

	public float m_HoursBeforeRoll;

	public float m_ChanceSpawnCarcassOnRoll;

	public float m_ChanceBreakOnRoll;

	private float m_HoursAtLastRoll;

	private SnareState m_RestoreStateWhenLeaveInspection;

	private GearItem m_GearItem;

	private static SnareItemSaveDataProxy m_SnareItemSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnareItem), Member = "SkipCheckDueToPlayerProximity")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSnarePlaced()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void EnableAllMeshes()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RefreshMeshes()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	public SnareState GetState()
	{
		return default(SnareState);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetSnarePlacedMesh")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(SnareItem), Member = "LeaveInspectMode")]
	[CalledBy(Type = typeof(SnareItem), Member = "OnSnarePlaced")]
	[CalledBy(Type = typeof(SnareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	public void SetState(SnareState state)
	{
	}

	[CallerCount(Count = 0)]
	public void EnterInspectMode()
	{
	}

	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallerCount(Count = 0)]
	public void LeaveInspectMode()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(SnareItem), Member = "Update")]
	[CalledBy(Type = typeof(SnareItem), Member = "CheckForCatch")]
	[CallsUnknownMethods(Count = 13)]
	private bool SkipCheckDueToPlayerProximity()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnareItem), Member = "SkipCheckDueToPlayerProximity")]
	private void CheckForCatch()
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(SnareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(SnareItem), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CalledBy(Type = typeof(SnareItem), Member = "CheckForCatch")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideSpawnRegion")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallsUnknownMethods(Count = 6)]
	private void DoRoll()
	{
	}

	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SpawnDeadRabbitOnSnare(GameObject rabbitPrefab)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SnareItem()
	{
	}
}
