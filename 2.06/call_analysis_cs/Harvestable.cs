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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
		[CompilerGenerated]
		[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHarvested()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CallerCount(Count = 0)]
	public bool HasToolRequired()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CalledBy(Type = typeof(Harvestable), Member = "HasToolRequired")]
	[CallsUnknownMethods(Count = 3)]
	public GearItem GetRequiredTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Harvestable), Member = "MaybeShowSecondaryItem")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectMode(GearItem gearPrefab)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "HarvestedPlant")]
	public void Harvest()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	public void MaybeShowSecondaryItem()
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ShowItemMessage(GearItem gi, string itemLocID, int num)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	private void RollSpawnChance()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 5)]
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
