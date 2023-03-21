using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

namespace NodeCanvas;

public class NCUtils
{
	public interface IItemRequirementsCollection
	{
		int GetNumGearWithName(string gearName);

		int GetMeasurableTotalByType(string type);
	}

	private const string START_FROM_RESTORE = "_startFromRestore";

	private const string START_BY_MISSION_JUMP = "_startByMissionJump";

	private static char[] m_FieldDividers;

	private static int tmpVarIndex;

	private static List<string> tagListsToRemove;

	[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Variable GetOrAddVar(IBlackboard bb, string name, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(Action_ShowChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_HideChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(Condition_EnterMissionTrigger), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_ContainerGetCalories), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_MissionSelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NPCSay), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_CheckNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetInvRequirementsCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GetWeightOfItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayerSay), Member = "DoSay")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 6)]
	public static Variable<T> GetOrAddVar<T>(IBlackboard bb, string name)
	{
		return null;
	}

	[CalledBy(TypeFullName = "MissionServicesManager.<JumpCo>d__130", Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "GetNodeWithTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[CallsUnknownMethods(Count = 9)]
	public static bool SetInitialStateByTag(FSM fsm, string tag)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetNodeWithTag")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool EnterStateByTag(FSM fsm, string tag)
	{
		return false;
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	public static GameObject SpawnChildGraph(GameObject prefab, GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddBlackboardMembersIfRequired(IBlackboard source, IBlackboard dest)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_RemoveConcurrentGraph), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_RestoreObjects), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static T GetHostState<T>(ActionTask action, IBlackboard bb) where T : class
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetSerializedBlackboard(Blackboard bb)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_CommandBlock), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[Calls(Type = typeof(NCUtils), Member = "ParseConditionalForCommandBlock")]
	[Calls(Type = typeof(NCUtils), Member = "TestConditional")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 46)]
	public static string ProcessCommandBlockLines(IBlackboard blackboard, string[] lines, IBlackboard writeBlackboard = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_Message), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 43)]
	public static string[] SubstituteVarsInStrings(IBlackboard blackboard, string[] lines)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "GetValue2")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue3")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue4")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CalledBy(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[CalledBy(Type = typeof(NCUtils), Member = "ParseConditional")]
	[CalledBy(Type = typeof(NCUtils), Member = "ParseConditionalForCommandBlock")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static object GetValue(string val, bool allowListDecl = true)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	private static object GetValue2(string[] fields)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	private static object GetValue3(string[] fields)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	private static object GetValue4(string[] fields)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	private static object GetValue5(string[] fields)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue5")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue4")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue3")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue2")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 50)]
	[CallsUnknownMethods(Count = 153)]
	public static string ProcessAssignmentString(IBlackboard readBlackboard, IBlackboard writeBlackboard, string str, int eq)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float SumMissionSelectionWeights(Dictionary<string, object>[] data)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static MissionManagerBase GetMissionManagerForFSM(IBlackboard blackboard)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string BuildFullStageName(string episode, string stage, string subStage, string worker1, string worker2)
	{
		return null;
	}

	[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public static void LogStateInfo(string state, string info)
	{
	}

	[CalledBy(Type = typeof(InventoryItemRequirement), Member = "TestRequirementCondition")]
	[CalledBy(Type = typeof(Condition_ConditionBlock), Member = "BuildVarCache")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static bool ParseConditional(IBlackboard blackboard, string str, out Variable lhVar, out string op, out Variable rhVar)
	{
		lhVar = null;
		op = null;
		rhVar = null;
		return false;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static bool ParseConditionalForCommandBlock(IBlackboard blackboard, string str, out Variable lhVar, out string op, out object rhVal)
	{
		lhVar = null;
		op = null;
		rhVal = null;
		return false;
	}

	[CalledBy(Type = typeof(InventoryItemRequirement), Member = "TestRequirementCondition")]
	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[CalledBy(Type = typeof(Condition_ConditionBlock), Member = "OnCheck")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 42)]
	public static bool TestConditional(Variable lhVar, string op, object rhVal)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_get_game_state")]
	[CalledBy(Type = typeof(TLD_CheckGameState), Member = "OnCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Condition), Member = "IsDegrading")]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(BrokenRib), Member = "HasBrokenRib")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 59)]
	public static bool GetGameState(MissionGameState gameState)
	{
		return false;
	}

	[CalledBy(Type = typeof(TLD_CheckContainerContains), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NCUtils), Member = "GetItemRequirementsMatchCount")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	public static bool TestItemRequirements(Dictionary<string, List<InventoryItemRequirement>> requirementsDict, IItemRequirementsCollection collection, bool mustHaveAll, IBlackboard blackboard, ITaskSystem taskSystemOwner)
	{
		return false;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "TestItemRequirements")]
	[CalledBy(Type = typeof(Action_GetInvRequirementsCount), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = "TestRequirementCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	public static int GetItemRequirementsMatchCount(Dictionary<string, List<InventoryItemRequirement>> requirementsDict, IItemRequirementsCollection collection, bool testAll, bool allowEarlyOut, IBlackboard blackboard, ITaskSystem taskSystemOwner)
	{
		return 0;
	}

	[CalledBy(Type = typeof(TLD_CheckContainerContains), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	[CalledBy(Type = typeof(Action_GetInvRequirementsCount), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static Dictionary<string, List<InventoryItemRequirement>> BuildRequirementsDictionary(List<InventoryItemRequirement> reqItemList)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_CheckContainerContains), Member = "get_info")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "get_info")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsValidRequirementIndex(List<InventoryItemRequirement> items, int index)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NCUtils()
	{
	}
}
