using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

public class LeanTo : MonoBehaviour
{
	public NavMeshObstacle m_NavmeshCut;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDisplayNameRuined;

	public LocalizedString m_LocalizedDisplayExitName;

	public int m_MinutesToBuild;

	public GearItem m_SticksPrefab;

	public int m_NumSticksToBuild;

	public GearItem m_BranchesPrefab;

	public int m_NumBranchesToBuild;

	public int m_MinutesForFullRepair;

	public int m_StickConditionPercentRepair;

	public int m_BranchConditionPercentRepair;

	public bool m_AllowDismantle;

	public int m_MinutesToDismantle;

	public int m_NumSticksFromDismantle;

	public int m_NumBranchesFromDismantle;

	public bool m_AllowRotate;

	public GameObject m_ExitPoint;

	public GameObject m_CameraDummy;

	public GameObject m_NormalMesh;

	public GameObject m_RuinedMesh;

	public Bed m_Bed;

	public Campfire m_Campfire;

	public float m_MaxHP;

	public float m_DailyDecayHP;

	public float m_BlizzardHourlyDecayHP;

	private PanelReference<Panel_LeanToInteract> m_InteractPanel;

	private float m_CurrentHP;

	private bool m_Ruined;

	private float m_HoursRuined;

	private bool m_StartHasBeenCalled;

	private string m_Guid;

	private static LeanToDataProxy m_LeanToDataProxy;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_DisplayNameRuined
	{
		[Calls(Type = typeof(Localization), Member = "Get")]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_DisplayExitName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(LeanToManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LeanToManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallerCount(Count = 2)]
	public void BuildFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsUnknownMethods(Count = 2)]
	public void RepairFinished(int numSticksUsed)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void DismantleFinished()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsRuined()
	{
		return default(bool);
	}

	[Calls(Type = typeof(LeanToManager), Member = "GetPlayerOccupiedLeanTo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LeanToManager), Member = "GetPlayerOccupiedLeanTo")]
	[Calls(Type = typeof(LeanToManager), Member = "ExitLeanTo")]
	[CallsUnknownMethods(Count = 3)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnRepair")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	public int GetNumSticksToRepair()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "NeedsRepair")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumBranchesToRepair()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "OnCancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Destroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHoursRuined()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(LeanToManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldRemove()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void OnExited()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnEntered()
	{
	}

	[CallerCount(Count = 0)]
	public LeanTo()
	{
	}
}
