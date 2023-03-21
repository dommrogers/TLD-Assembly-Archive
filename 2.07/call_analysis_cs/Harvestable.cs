using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class Harvestable : MonoBehaviour
{
	public float m_SpawnChance;

	public GearItem m_InspectItem;

	public GearItem m_GearPrefab;

	public int m_GearItemCountMin;

	public int m_GearItemCountMax;

	public GearItem m_SecondGearPrefab;

	public int m_SecondGearItemCountMin;

	public int m_SecondGearItemCountMax;

	public string m_HarvestAudio;

	public GameObject[] m_RequiredToolList;

	public string m_RequiredToolText;

	public GameObject m_ActivateObjectPostHarvest;

	public bool m_DestroyObjectOnHarvest;

	public bool m_IgnoreCustomModeSpawnChance;

	private int m_NumPrimary;

	private int m_NumSecondary;

	private bool m_Harvested;

	private bool m_StartHasBeenCalled;

	private bool m_HasInspectedSecondary;

	private static HarvestableSaveDataProxy m_HarvestableSaveDataProxy;

	public event Action Harvested
	{
		[CalledBy(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(MapDetail), Member = "Register")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHarvested()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CallerCount(Count = 0)]
	public bool HasToolRequired()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Harvestable), Member = "HasToolRequired")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	public GearItem GetRequiredTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Harvestable), Member = "MaybeShowSecondaryItem")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void EnterInspectMode(GearItem gearPrefab)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	public void Harvest()
	{
	}

	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CallerCount(Count = 0)]
	public void MaybeShowSecondaryItem()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	private void ShowItemMessage(GearItem gi, string itemLocID, int num)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	private void RollSpawnChance()
	{
	}

	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 0)]
	public Harvestable()
	{
	}
}
