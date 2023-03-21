using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class TrustManager : MonoBehaviour
{
	[Serializable]
	public class TheftTrustLossTunables
	{
		public int m_ContainerInspected;

		public int m_ItemBreakdown;

		public int m_ItemStolen;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public TheftTrustLossTunables()
		{
		}
	}

	[Serializable]
	public class TrustDecayValue
	{
		public string m_NPCTrustID;

		public float m_TrustPointDecayPerDay;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public TrustDecayValue()
		{
		}
	}

	private PanelReference<Panel_BreakDown> m_BreakDown;

	public int m_MinTrustValue;

	public int m_MaxTrustValue;

	public int m_DefaultTrustValue;

	public bool m_DisableTrustForRedux;

	public TheftTrustLossTunables m_TheftTrustLossTunables;

	public TrustDecayValue[] m_TrustDecayValues;

	private Dictionary<string, int> m_TrustDictionary;

	private Dictionary<string, int> m_StrikesDictionary;

	private Dictionary<string, float> m_StrikeTimersDictionary;

	private Dictionary<string, NPC_NeedTracker> m_NeedTrackers;

	private Dictionary<string, NPC_UnlockableTracker> m_UnlockableTrackers;

	private Dictionary<string, float> m_TrustDecayDictionary;

	private Dictionary<string, float> m_TrustDecayValuesDictionary;

	private Dictionary<string, float> m_GracePeriodTimersDictionary;

	private Dictionary<string, float> m_GracePeriodValuesDictionary;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "SerializeNeedTrackers")]
	[Calls(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(TrustManager), Member = "StrikeTimerReduce")]
	[Calls(Type = typeof(TrustManager), Member = "AddGracePeriodHours")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustDecayPerDay")]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	public void RegisterNeedTracker(NPC_NeedTracker needTracker, string id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	public void RegisterUnlockableTracker(NPC_UnlockableTracker unlockableTracker, string id)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CallsUnknownMethods(Count = 1)]
	public void AddTrustDecayGracePeriod(string npcID, string missionID, float gracePeriodHours)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void RemoveTrustDecayGracePeriod(string npcID, string missionID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetTrustDecayGracePeriod(string npcID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_NPCTrustValue), Member = "OnCheck")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(TrustManager), Member = "GetNormalizedTrustValue")]
	public int GetTrustValue(string id)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	public float GetNormalizedTrustValue(string id)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetNPCTrustValue), Member = "OnExecute")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	public void SetTrustValue(string id, int val)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[CalledBy(Type = typeof(Action_AddToNPCTrustValue), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_trust_add")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleContainerTheft")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustChangeMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TrustManager), Member = "AddStrike")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallerCount(Count = 6)]
	public void AddToTrustValue(string id, int amountToAdd)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public string GetTrustChangeMessage(string id, int amountToAdd)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	public void AddStrike(string id)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetNumStrikes(string id)
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_RemoveNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_CheckNPCNeed), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public NPC_NeedTracker GetNeedTracker(string id)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_UnlockNPCUnlockable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	public NPC_UnlockableTracker GetUnlockableTracker(string id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public List<string> GetAllTrustIDs()
	{
		return null;
	}

	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeHandleContainerTheft(GameObject containerObject)
	{
	}

	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CallerCount(Count = 0)]
	public static void MaybeHandleItemTheft(GearItem gearItem)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeHandleItemBreakdown(GameObject breakdownObject)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_trust_value_list")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	public void OutputTrustValues()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputTrustValues")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputTrustValues")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void OutputSingleTrustValue(string npcID, int trustVal)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	private void AddTrustDecay(string npcID, float decayPerDay, float deltaTimeDays)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetTrustDecayPerDay(string npcID)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	private bool TrustDecayInGracePeriod(string npcID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CalledBy(Type = typeof(TrustManager), Member = "TrustDecayInGracePeriod")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private float GetHighestGracePeriodThreshold(string npcID)
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "TrustDecayInGracePeriod")]
	[CallsUnknownMethods(Count = 2)]
	private float GetGracePeriodTimerHours(string npcID)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void AddGracePeriodHours(string npcID, float hoursToAdd)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(TrustManager), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 8)]
	private Dictionary<string, string> SerializeNeedTrackers()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Serialize")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(TrustManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 21)]
	private Dictionary<string, string> SerializeUnlockableTrackers()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "RegisterNeedTracker")]
	private void DeserializeNeedTrackers(Dictionary<string, string> needTrackersSerialized)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Deserialize")]
	[Calls(Type = typeof(TrustManager), Member = "RegisterUnlockableTracker")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void DeserializeUnlockableTrackers(Dictionary<string, string> unlockableTrackersSerialized)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void StartStrikeCooldown(string id, float numHours)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void StrikeTimerReduce(string id, float numHours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public TrustManager()
	{
	}
}
