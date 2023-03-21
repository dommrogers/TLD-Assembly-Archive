using System;
using Cpp2ILInjected.CallAnalysis;
using TLD;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class MapDetailManager : MonoBehaviour
{
	private PanelReference<Panel_Map> m_Map;

	public float m_ResourceRemovalDelay;

	private static MapDetailSaveData m_MapDetailSaveData;

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[Calls(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MapDetailUnlockParameters), Member = "GetRangeBoostFromHeightDelta")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(VistaLocation), Member = "HasRequiredGearItem")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	public bool UnlockMapDetailObjectsNearPosition(MapDetailUnlockParameters parameters)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	public void MaybeUnlockFaithfulCartographer()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_log_faithful_cartographer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 6)]
	public void LogAllUnmappedLocations()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey_clear")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	public void LockAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasBeenDiscovered(MapDetail md)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public MapDetailManager()
	{
	}
}
