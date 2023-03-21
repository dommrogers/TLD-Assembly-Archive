using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Harvestable : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public float m_SpawnChance;

	public GearItem m_InspectItem;

	public GearItem m_GearPrefab;

	public int m_GearItemCountMin;

	public int m_GearItemCountMax;

	public GearItem m_SecondGearPrefab;

	public int m_SecondGearItemCountMin;

	public int m_SecondGearItemCountMax;

	public string m_HarvestAudio;

	public float m_SecondsToHarvest;

	public GameObject[] m_RequiredToolList;

	public string m_RequiredToolText;

	public GameObject m_ActivateObjectPostHarvest;

	public bool m_DestroyObjectOnHarvest;

	public bool m_IgnoreCustomModeSpawnChance;

	private int m_NumPrimary;

	private int m_NumSecondary;

	private uint m_ProgressBarAudio;

	private bool m_Harvested;

	private bool m_StartHasBeenCalled;

	private float m_HarvestTimeRemaining;

	private bool m_HasInspectedSecondary;

	private PlayerControlMode m_RestoreControlMode;

	private static HarvestableSaveDataProxy m_HarvestableSaveDataProxy;

	public event Action Harvested
	{
		[CalledBy(Type = typeof(MapDetail), Member = "SetupMapVisibility")]
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HarvestableManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Harvestable), Member = "CancelHarvest")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Harvestable), Member = "CompletedHarvest")]
	public void UpdateHarvesting()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Harvestable), Member = "AddAlternateTools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsToolRequired()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Harvestable), Member = "IsToolRequired")]
	[CalledBy(Type = typeof(Harvestable), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Harvestable), Member = "DoHarvest")]
	[CallsUnknownMethods(Count = 7)]
	public GearItem GetRequiredTool()
	{
		return null;
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Harvestable), Member = "DoHarvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Harvestable), Member = "MaybeShowSecondaryItem")]
	[CalledBy(Type = typeof(Harvestable), Member = "UpdateHarvesting")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectMode(GearItem gearPrefab)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Harvestable), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void DoHarvest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[Calls(Type = typeof(Harvestable), Member = "CompletedHarvest")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(Harvestable), Member = "UpdateHarvesting")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void CancelHarvest()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Harvestable), Member = "UpdateHarvesting")]
	[CalledBy(Type = typeof(Harvestable), Member = "CancelHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AchievementManager), Member = "HarvestedPlant")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	public void CompletedHarvest(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	public void MaybeShowSecondaryItem()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Harvestable), Member = "CompletedHarvest")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Harvestable), Member = "CompletedHarvest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	private void ShowItemMessage(GearItem gi, string itemLocID, int num)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	private void RollSpawnChance()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Harvestable), Member = "Start")]
	[CalledBy(Type = typeof(Harvestable), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 25)]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void StopProgressBarAudio()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Harvestable()
	{
	}
}
