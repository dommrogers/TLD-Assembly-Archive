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
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(VistaLocation), Member = "HasRequiredGearItem")]
	[Calls(Type = typeof(MapDetailUnlockParameters), Member = "GetRangeBoostFromHeightDelta")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	public bool UnlockMapDetailObjectsNearPosition(MapDetailUnlockParameters parameters)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(AchievementManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public void MaybeUnlockFaithfulCartographer()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_log_faithful_cartographer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	public void LogAllUnmappedLocations()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey_clear")]
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
