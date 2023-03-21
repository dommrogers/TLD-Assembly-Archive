using Cpp2ILInjected.CallAnalysis;
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
	[DeduplicatedMethod]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SkipCheckDueToPlayerProximity")]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSnarePlaced()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void EnableAllMeshes()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RefreshMeshes()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	public SnareState GetState()
	{
		return default(SnareState);
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetSnarePlacedMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(SnareItem), Member = "LeaveInspectMode")]
	[CalledBy(Type = typeof(SnareItem), Member = "OnSnarePlaced")]
	[CalledBy(Type = typeof(SnareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	public void SetState(SnareState state)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void EnterInspectMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	public void LeaveInspectMode()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SnareItem), Member = "Update")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(SnareItem), Member = "CheckForCatch")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private bool SkipCheckDueToPlayerProximity()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[Calls(Type = typeof(SnareItem), Member = "SkipCheckDueToPlayerProximity")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CheckForCatch()
	{
	}

	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SnareItem), Member = "CheckForCatch")]
	[CalledBy(Type = typeof(SnareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(SnareItem), Member = "Update")]
	[Calls(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideSpawnRegion")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void DoRoll()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SpawnDeadRabbitOnSnare(GameObject rabbitPrefab)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SnareItem()
	{
	}
}
