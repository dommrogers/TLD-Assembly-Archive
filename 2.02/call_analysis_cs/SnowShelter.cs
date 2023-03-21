using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

public class SnowShelter : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

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

	public NavMeshObstacle m_NavmeshCut;

	private float m_CurrentHP;

	private bool m_Ruined;

	private float m_HoursRuined;

	private bool m_StartHasBeenCalled;

	private string m_Guid;

	private static SnowShelterDataProxy m_SnowShelterDataProxy;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		get
		{
			return null;
		}
	}

	public string m_DisplayNameRuined
	{
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	public string m_DisplayExitName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 15)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsUnknownMethods(Count = 6)]
	public void BuildFinished()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void RepairFinished(int numSticksUsed, int numClothUsed)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void DismantleFinished()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsRuined()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowShelter), Member = "DismantleFinished")]
	[CalledBy(Type = typeof(SnowShelter), Member = "GetNumSticksToRepair")]
	[CalledBy(Type = typeof(SnowShelter), Member = "GetNumClothToRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateConditionLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "GetTaskDurationInHours")]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetPlayerOccupiedSnowShelter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelter), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	public int GetNumSticksToRepair()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(SnowShelter), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public int GetNumClothToRepair()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SnowShelter()
	{
	}
}
