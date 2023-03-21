using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
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
		[CallerCount(Count = 2)]
		public TheftTrustLossTunables()
		{
		}
	}

	[Serializable]
	public class TrustDecayValue
	{
		public string m_NPCTrustID;

		public float m_TrustPointDecayPerDay;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public TrustDecayValue()
		{
		}
	}

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
	[Calls(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "SerializeNeedTrackers")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[Calls(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(TrustManager), Member = "StrikeTimerReduce")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(TrustManager), Member = "AddGracePeriodHours")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustDecayPerDay")]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterNeedTracker(NPC_NeedTracker needTracker, string id)
	{
	}

	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Start")]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RegisterUnlockableTracker(NPC_UnlockableTracker unlockableTracker, string id)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CallsUnknownMethods(Count = 2)]
	public void AddTrustDecayGracePeriod(string npcID, string missionID, float gracePeriodHours)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void RemoveTrustDecayGracePeriod(string npcID, string missionID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ResetTrustDecayGracePeriod(string npcID)
	{
	}

	[CalledBy(Type = typeof(Condition_NPCTrustValue), Member = "OnCheck")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "IsTrustWithinNeedRange")]
	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(TrustManager), Member = "GetNormalizedTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CallsUnknownMethods(Count = 2)]
	public int GetTrustValue(string id)
	{
		return default(int);
	}

	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallerCount(Count = 0)]
	public float GetNormalizedTrustValue(string id)
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddTrustDecay")]
	[CalledBy(Type = typeof(Action_SetNPCTrustValue), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	public void SetTrustValue(string id, int val)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[CalledBy(Type = typeof(TrustManager), Member = "MaybeHandleContainerTheft")]
	[CalledBy(Type = typeof(Action_AddToNPCTrustValue), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_trust_add")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustChangeMessage")]
	[Calls(Type = typeof(TrustManager), Member = "AddStrike")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Container), Member = "OnContainerSearchComplete")]
	public void AddToTrustValue(string id, int amountToAdd)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetTrustChangeMessage(string id, int amountToAdd)
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public void AddStrike(string id)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumStrikes(string id)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_CheckNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_RemoveNPCNeed), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupNeedsInfo")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	public NPC_NeedTracker GetNeedTracker(string id)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(Action_UnlockNPCUnlockable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public NPC_UnlockableTracker GetUnlockableTracker(string id)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateTrustListData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public List<string> GetAllTrustIDs()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 3)]
	public static void MaybeHandleContainerTheft(GameObject containerObject)
	{
	}

	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	public static void MaybeHandleItemTheft(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 3)]
	public static void MaybeHandleItemBreakdown(GameObject breakdownObject)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_trust_value_list")]
	[Calls(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	public void OutputTrustValues()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputTrustValues")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputTrustValues")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 73)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TrustManager), Member = "GetHighestGracePeriodThreshold")]
	[Calls(Type = typeof(TrustManager), Member = "GetGracePeriodTimerHours")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void OutputSingleTrustValue(string npcID, int trustVal)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void AddTrustDecay(string npcID, float decayPerDay, float deltaTimeDays)
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "TrustDecayInGracePeriod")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	private float GetHighestGracePeriodThreshold(string npcID)
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "OutputSingleTrustValue")]
	[CalledBy(Type = typeof(TrustManager), Member = "TrustDecayInGracePeriod")]
	[CallsUnknownMethods(Count = 7)]
	private float GetGracePeriodTimerHours(string npcID)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void AddGracePeriodHours(string npcID, float hoursToAdd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Serialize")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Serialize")]
	[CalledBy(Type = typeof(TrustManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 24)]
	private Dictionary<string, string> SerializeNeedTrackers()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Serialize")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Serialize")]
	[CallsUnknownMethods(Count = 24)]
	private Dictionary<string, string> SerializeUnlockableTrackers()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(TrustManager), Member = "RegisterNeedTracker")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void DeserializeNeedTrackers(Dictionary<string, string> needTrackersSerialized)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(TrustManager), Member = "RegisterUnlockableTracker")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "Deserialize")]
	[CalledBy(Type = typeof(TrustManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 13)]
	private void DeserializeUnlockableTrackers(Dictionary<string, string> unlockableTrackersSerialized)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void StartStrikeCooldown(string id, float numHours)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(TrustManager), Member = "Update")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	private void StrikeTimerReduce(string id, float numHours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 72)]
	public TrustManager()
	{
	}
}
