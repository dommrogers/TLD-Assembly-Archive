using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

public class SnowShelter : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayNameRuined;

	public LocalizedString m_LocalizedDisplayExitName;

	public int m_MinutesToBuild;

	public GearItem m_SticksPrefab;

	public GearItem m_ClothPrefab;

	public int m_NumSticksToBuild;

	public int m_NumClothToBuild;

	public int m_MinutesForFullRepair;

	public int m_StickConditionPercentRepair;

	public int m_ClothConditionPercentRepair;

	public bool m_AllowDismantle;

	public int m_MinutesToDismantle;

	public int m_NumSticksFromDismantle;

	public int m_NumClothFromDismantle;

	public GameObject m_ExitPoint;

	public GameObject m_CameraDummy;

	public GameObject m_NormalMesh;

	public GameObject m_RuinedMesh;

	public SnowImprintCustom m_GroundImprint;

	public Bed m_Bed;

	public float m_MaxHP;

	public float m_DailyDecayHP;

	public float m_BlizzardHourlyDecayHP;

	private PanelReference<Panel_SnowShelterInteract> m_InteractPanel;

	public NavMeshObstacle m_NavmeshCut;

	private string _003CGUID_003Ek__BackingField;

	private float m_CurrentHP;

	private bool m_Ruined;

	private float m_HoursRuined;

	private bool m_StartHasBeenCalled;

	private static SnowShelterDataProxy m_SnowShelterDataProxy;

	public string GUID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 9)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	public void BuildFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsUnknownMethods(Count = 3)]
	public void RepairFinished(int numSticksUsed, int numClothUsed)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void DismantleFinished()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRuined()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumSticksToRepair()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	public int GetNumClothToRepair()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	public void Destroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHoursRuined()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnExited()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnEntered()
	{
	}

	[CallerCount(Count = 0)]
	public SnowShelter()
	{
	}
}
