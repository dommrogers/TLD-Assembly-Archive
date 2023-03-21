using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class StartGear : MonoBehaviour
{
	public GearItem[] m_StartGearPilgrim;

	public int[] m_NumUnitsPilgrim;

	public GearItem[] m_StartGearVoyageur;

	public int[] m_NumUnitsVoyageur;

	public GearItem[] m_StartGearStalker;

	public int[] m_NumUnitsStalker;

	public GearItem[] m_StartGearInterloper;

	public int[] m_NumUnitsInterloper;

	public GearItem[] m_StartGearChallengeHunted;

	public int[] m_NumUnitsChallengeHunted;

	public GearItem[] m_StartGearStory;

	public int[] m_NumUnitsStory;

	public GearItem[] m_StartGearStoryEpTwo;

	public int[] m_NumUnitsStoryEpTwo;

	public GearItem[] m_StartGearStoryEpThree;

	public int[] m_NumUnitsStoryEpThree;

	public GearItem[] m_StartGearStoryEpFour;

	public int[] m_NumUnitsStoryEpFour;

	public GearItem[] m_StartGearStoryEpFive;

	public int[] m_NumUnitsStoryEpFive;

	public GearItem[] m_StartGearChallengeWhiteout;

	public int[] m_NumUnitsChallengeWhiteout;

	public GearItem[] m_StartGearChallengeHuntedPart2;

	public int[] m_NumUnitsChallengeHuntedPart2;

	public LootTable[] m_LootTablesPilgrim;

	public int[] m_MinValuesPilgrim;

	public int[] m_MaxValuesPilgrim;

	public LootTable[] m_LootTablesVoyageur;

	public int[] m_MinValuesVoyageur;

	public int[] m_MaxValuesVoyageur;

	public LootTable[] m_LootTablesStalker;

	public int[] m_MinValuesStalker;

	public int[] m_MaxValuesStalker;

	public LootTable[] m_LootTablesInterloper;

	public int[] m_MinValuesInterloper;

	public int[] m_MaxValuesInterloper;

	public LootTable[] m_LootTablesChallengeHunted;

	public int[] m_MinValuesChallengeHunted;

	public int[] m_MaxValuesChallengeHunted;

	public LootTable[] m_LootTablesChallengeWhiteout;

	public int[] m_MinValuesChallengeWhiteout;

	public int[] m_MaxValuesChallengeWhiteout;

	public LootTable[] m_LootTablesChallengeHuntedPart2;

	public int[] m_MinValuesChallengeHuntedPart2;

	public int[] m_MaxValuesChallengeHuntedPart2;

	public LootTable[] m_LootTablesStory;

	public int[] m_MinValuesStory;

	public int[] m_MaxValuesStory;

	public LootTable[] m_LootTablesStoryEpTwo;

	public int[] m_MinValuesStoryEpTwo;

	public int[] m_MaxValuesStoryEpTwo;

	public LootTable[] m_LootTablesStoryEpThree;

	public int[] m_MinValuesStoryEpThree;

	public int[] m_MaxValuesStoryEpThree;

	public LootTable[] m_LootTablesStoryEpFour;

	public int[] m_MinValuesStoryEpFour;

	public int[] m_MaxValuesStoryEpFour;

	public LootTable[] m_LootTablesStoryEpFive;

	public int[] m_MinValuesStoryEpFive;

	public int[] m_MaxValuesStoryEpFive;

	public GearItem[] m_StartGearChallengeDeadManWalking;

	public int[] m_NumUnitsChallengeDeadManWalking;

	public LootTable[] m_LootTablesChallengeDeadManWalking;

	public int[] m_MinValuesChallengeDeadManWalking;

	public int[] m_MaxValuesChallengeDeadManWalking;

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 72)]
	public void AddAllToInventory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StartGear()
	{
	}
}
