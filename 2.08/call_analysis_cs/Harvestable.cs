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
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(MapDetail), Member = "Register")]
		[CalledBy(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHarvested()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	public bool HasToolRequired()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Harvestable), Member = "HasToolRequired")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CallerCount(Count = 3)]
	public GearItem GetRequiredTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Harvestable), Member = "MaybeShowSecondaryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void EnterInspectMode(GearItem gearPrefab)
	{
	}

	[Calls(Type = typeof(string), Member = "Contains")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	public void MaybeShowSecondaryItem()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Contains")]
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

	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 0)]
	public Harvestable()
	{
	}
}
