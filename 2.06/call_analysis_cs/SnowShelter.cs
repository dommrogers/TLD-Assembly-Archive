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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsUnknownMethods(Count = 1)]
	public void BuildFinished()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void RepairFinished(int numSticksUsed, int numClothUsed)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
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

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[CallsUnknownMethods(Count = 2)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	public int GetNumSticksToRepair()
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumClothToRepair()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnEntered()
	{
	}

	[CallerCount(Count = 0)]
	public SnowShelter()
	{
	}
}
