using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_Map> m_Map;

	[NonSerialized]
	public string m_RegionName;

	[NonSerialized]
	public string m_SceneName;

	private string m_Guid;

	private bool m_UserPlaced;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(RockCacheManager), Member = "SetRockCacheRegionName")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RockCacheManager), Member = "Add")]
	[Calls(Type = typeof(RockCacheManager), Member = "WasDestroyed")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUserPlaced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCacheManager), Member = "CanPlaceRockCache")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanPlaceInWorld()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(RockCache), Member = "Deserialize")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RockCacheManager), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Activate(string guid)
	{
	}

	[CalledBy(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CallsUnknownMethods(Count = 2)]
	public void SetMapDetailName(string name)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RockCache), Member = "Activate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RockCacheManager), Member = "WasDestroyed")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(RockCache), Member = "DismantleCallback")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(RockCache), Member = "OnDismantle")]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[Calls(Type = typeof(RockCacheManager), Member = "TrackDestroyedRockCacheInScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RockCacheManager), Member = "Remove")]
	public void Destroy()
	{
	}

	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void OnBuild()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RockCache), Member = "BuildFinished")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CalledBy(Type = typeof(RockCache), Member = "OnBuild")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RockCache), Member = "Activate")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(RockCacheManager), Member = "SetRockCacheRegionName")]
	private void SetupInWorld()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	public void BuildFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 1)]
	public void BuildCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	public void OnLabel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(RockCache), Member = "DismantleFinished")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnDismantle()
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CalledBy(Type = typeof(RockCache), Member = "DismantleCallback")]
	[CalledBy(Type = typeof(RockCache), Member = "OnDismantle")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	private void DismantleFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCache), Member = "DismantleFinished")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	public void DismantleCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public RockCache()
	{
	}
}
