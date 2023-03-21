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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "SerializeNeedTrackers")]
	[Calls(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[Calls(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustDecayPerDay")]
	[Calls(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[Calls(Type = typeof(TrustManager), Member = "AddGracePeriodHours")]
	[Calls(Type = typeof(TrustManager), Member = "StrikeTimerReduce")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterNeedTracker(NPC_NeedTracker needTracker, string id)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterUnlockableTracker(NPC_UnlockableTracker unlockableTracker, string id)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AddTrustDecayGracePeriod(string npcID, string missionID, float gracePeriodHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveTrustDecayGracePeriod(string npcID, string missionID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetTrustDecayGracePeriod(string npcID)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(TrustManager), Member = "GetNormalizedTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CalledBy(Type = typeof(Condition_NPCTrustValue), Member = "OnCheck")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetTrustValue(string id)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	public float GetNormalizedTrustValue(string id)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CalledBy(Type = typeof(Action_SetNPCTrustValue), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetTrustValue(string id, int val)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_trust_add")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleContainerTheft")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[CalledBy(Type = typeof(Action_AddToNPCTrustValue), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "AddStrike")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustChangeMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void AddToTrustValue(string id, int amountToAdd)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	public string GetTrustChangeMessage(string id, int amountToAdd)
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void AddStrike(string id)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumStrikes(string id)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_RemoveNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_CheckNPCNeed), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NPC_NeedTracker GetNeedTracker(string id)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(Action_UnlockNPCUnlockable), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NPC_UnlockableTracker GetUnlockableTracker(string id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<string> GetAllTrustIDs()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeHandleContainerTheft(GameObject containerObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeHandleItemTheft(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeHandleItemBreakdown(GameObject breakdownObject)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_trust_value_list")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public void OutputTrustValues()
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "OutputTrustValues")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 57)]
	private void OutputSingleTrustValue(string npcID, int trustVal)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void AddTrustDecay(string npcID, float decayPerDay, float deltaTimeDays)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetTrustDecayPerDay(string npcID)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	private bool TrustDecayInGracePeriod(string npcID)
	{
		return false;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "TrustDecayInGracePeriod")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private float GetHighestGracePeriodThreshold(string npcID)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "TrustDecayInGracePeriod")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetGracePeriodTimerHours(string npcID)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void AddGracePeriodHours(string npcID, float hoursToAdd)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Serialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private Dictionary<string, string> SerializeNeedTrackers()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Serialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private Dictionary<string, string> SerializeUnlockableTrackers()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(TrustManager), Member = "RegisterNeedTracker")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void DeserializeNeedTrackers(Dictionary<string, string> needTrackersSerialized)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(TrustManager), Member = "RegisterUnlockableTracker")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
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
