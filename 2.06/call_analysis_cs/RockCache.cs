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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(RockCacheManager), Member = "WasDestroyed")]
	[Calls(Type = typeof(RockCacheManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(RockCacheManager), Member = "SetRockCacheRegionName")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUserPlaced()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCacheManager), Member = "CanPlaceRockCache")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanPlaceInWorld()
	{
		return false;
	}

	[CalledBy(Type = typeof(RockCache), Member = "Deserialize")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(RockCacheManager), Member = "Add")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheName")]
	[Calls(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Activate(string guid)
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CallsUnknownMethods(Count = 2)]
	public void SetMapDetailName(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(RockCacheManager), Member = "WasDestroyed")]
	[Calls(Type = typeof(RockCache), Member = "Activate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[CalledBy(Type = typeof(RockCache), Member = "OnDismantle")]
	[CalledBy(Type = typeof(RockCache), Member = "DismantleCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RockCacheManager), Member = "TrackDestroyedRockCacheInScene")]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[Calls(Type = typeof(RockCacheManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	public void OnBuild()
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnBuild")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildFinished")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RockCache), Member = "Activate")]
	[Calls(Type = typeof(RockCacheManager), Member = "SetRockCacheRegionName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetupInWorld()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 1)]
	public void BuildFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 1)]
	public void BuildCallback(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheName")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void OnLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(RockCache), Member = "DismantleFinished")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	public void OnDismantle()
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnDismantle")]
	[CalledBy(Type = typeof(RockCache), Member = "DismantleCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsUnknownMethods(Count = 6)]
	public RockCache()
	{
	}
}
