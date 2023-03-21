using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Tunable;
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
		[CalledBy(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHarvested()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool HasToolRequired()
	{
		return false;
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CalledBy(Type = typeof(Harvestable), Member = "HasToolRequired")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	public GearItem GetRequiredTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(Harvestable), Member = "MaybeShowSecondaryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	public void EnterInspectMode(GearItem gearPrefab)
	{
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "HarvestedPlant")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void Harvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	public void MaybeShowSecondaryItem()
	{
	}

	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void ShowItemMessage(GearItem gi, string itemLocID, int num)
	{
	}

	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RollSpawnChance()
	{
	}

	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 0)]
	public Harvestable()
	{
	}
}
