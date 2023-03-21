using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class RockCacheManager : MonoBehaviour
{
	public RockCache m_RockCachePrefab;

	public float m_BuildRangeMin;

	public float m_BuildRangeMax;

	public int m_MaxRockCachesPerRegion;

	public float m_MinDistanceBetweenRockCaches;

	public float m_FOV;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_FadeOutSeconds;

	public float m_FadeInSeconds;

	public string m_BuildAudio;

	public string m_DismantleAudio;

	public static bool s_Locked;

	public static bool s_RockCachesUnlockedInStory;

	private float m_StartCameraFOV;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	public static Dictionary<string, RockCacheInfo> s_RockCacheInfoByGuid;

	private static List<RockCache> s_RockCacheList;

	private static Dictionary<string, List<string>> s_DestroyedRockCacheInScene;

	public static bool s_IsDeserializing;

	private static int s_RockCacheIndex;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public string GenerateRockCacheName()
	{
		return null;
	}

	[CalledBy(Type = typeof(RockCacheManager), Member = "Add")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "Add")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void AddRockCacheInfo(RockCache rc)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RockCacheManager), Member = "AddRockCacheInfo")]
	[Calls(Type = typeof(RockCacheManager), Member = "AddRockCacheInfo")]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(RockCache rc)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static void RemoveRockCacheInfo(RockCache rc)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeGlobal")]
	[CallsUnknownMethods(Count = 2)]
	public static void Remove(RockCache rc)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(RockCache), Member = "Destroy")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeGlobal")]
	[CallsUnknownMethods(Count = 2)]
	public static void TrackDestroyedRockCacheInScene(string sceneName, string guid)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RockCache), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[CallerCount(Count = 2)]
	public static bool WasDestroyed(string sceneName, string guid)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "GetRockCacheName")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetItemInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	public static string GetRockCacheNameFromGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetRockCacheSceneNameFromGuid(string guid)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string GetRockCacheUserText(RockCache rc)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	public static string GetRockCacheUserTextFromGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 GetRockCacheLocationFromGuid(string guid)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetRockCacheName(RockCache rc)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetRockCacheRegionName(RockCache rc, string sceneName, string regionName)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void UpdateRockCacheName(RockCache rc, string name)
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnRenameRockCacheConfirmed")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameRockCacheConfirmed")]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[Calls(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[Calls(Type = typeof(Panel_Map), Member = "RenameMapMarkerFromGuid")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public static void UpdateRockCacheName(string rockCacheGuid, string name)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void UpdateRockCacheUserText(RockCache rc, string userText)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateNote")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void UpdateRockCacheUserText(string rockCacheGuid, string userText)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 17)]
	public static string SerializeGlobal()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RockCacheManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(RockCacheManager), Member = "TrackDestroyedRockCacheInScene")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void DeserializeGlobal(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RockCache), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RockCache), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	public static void RegisterAnyRockCacheGuid()
	{
	}

	[CallerCount(Count = 0)]
	public void RockCachesUnlockInStory()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public bool RockCachesAreUnlocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public int GetNumSticksInInventory()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public int GetNumRocksInInventory()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoRockCacheMessage")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceRockCache")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "CanAttemptToPlaceRockCache")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetNumRocksInInventory")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(RockCache), Member = "CanPlaceInWorld")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 10)]
	public bool CanPlaceRockCache(RockCache newRockCache)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetRockCachesPerRegion()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoRockCacheMessage")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "CanAttemptToPlaceRockCache")]
	[CallsUnknownMethods(Count = 5)]
	public bool HasReachedMaxRockCacheCount()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceRockCache")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(RockCacheManager), Member = "HasReachedMaxRockCacheCount")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	public bool CanAttemptToPlaceRockCache()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public RockCacheManager()
	{
	}
}
