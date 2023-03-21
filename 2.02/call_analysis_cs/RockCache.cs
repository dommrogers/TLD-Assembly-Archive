using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class RockCache : MonoBehaviour
{
	public NavMeshObstacle m_NavmeshCut;

	protected Container m_Container;

	protected MapDetail m_MapDetail;

	public LocalizedString m_LocalizedDisplayName;

	public int m_BuildRealSecondsElapsed;

	public int m_MinutesToBuild;

	public GearItem m_RocksPrefab;

	public int m_NumRocksToBuild;

	public GearItem m_SticksPrefab;

	public int m_NumSticksToBuild;

	public string m_BuildAudioName;

	public string m_BuildIconName;

	public string m_LabelIconName;

	public LocalizedString m_InteractProgressDisplayName;

	public int m_DismantleRealSecondsElapsed;

	public int m_MinutesToDismantle;

	public int m_NumRocksFromDismantle;

	public int m_NumSticksFromDismantle;

	public string m_DismantleAudioName;

	public string m_DismantleIconName;

	public bool m_OnlyAllowOpen;

	public float m_OpenTimeSeconds;

	[NonSerialized]
	public string m_RegionName;

	[NonSerialized]
	public string m_SceneName;

	private string m_Guid;

	private bool m_UserPlaced;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(RockCacheManager), Member = "SetRockCacheRegionName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(RockCacheManager), Member = "Add")]
	[Calls(Type = typeof(RockCacheManager), Member = "WasDestroyed")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(RockCache), Member = "CancelInteraction")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUserPlaced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RockCacheManager), Member = "CanPlaceRockCache")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanPlaceInWorld()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[Calls(Type = typeof(RockCacheManager), Member = "Add")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheName")]
	[Calls(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CalledBy(Type = typeof(RockCache), Member = "Deserialize")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 3)]
	public void Activate(string guid)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	public void SetMapDetailName(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RockCacheManager), Member = "WasDestroyed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RockCache), Member = "Activate")]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	public bool StartInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(RockCache), Member = "OnRenameCancel")]
	[CalledBy(Type = typeof(RockCache), Member = "OnActionPickerCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(RockCache), Member = "Update")]
	public void CancelInteraction()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsUnknownMethods(Count = 69)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(RockCache), Member = "DismantleCallback")]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[Calls(Type = typeof(RockCacheManager), Member = "TrackDestroyedRockCacheInScene")]
	[Calls(Type = typeof(RockCacheManager), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnBuild()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCache), Member = "CancelInteraction")]
	private void OnActionPickerCancel()
	{
	}

	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RockCache), Member = "BuildFinished")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[Calls(Type = typeof(RockCacheManager), Member = "SetRockCacheRegionName")]
	[Calls(Type = typeof(RockCache), Member = "Activate")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	private void SetupInWorld()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	public void BuildFinished()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	public void BuildCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CallsUnknownMethods(Count = 10)]
	public void OnOpen()
	{
	}

	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheName")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 22)]
	public void OnLabel()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCache), Member = "CancelInteraction")]
	private void OnRenameCancel(bool cancel)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 8)]
	public void OnDismantle()
	{
	}

	[CallsUnknownMethods(Count = 44)]
	[CalledBy(Type = typeof(RockCache), Member = "DismantleCallback")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	private void DismantleFinished()
	{
	}

	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(RockCache), Member = "DismantleFinished")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DismantleCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public RockCache()
	{
	}
}
