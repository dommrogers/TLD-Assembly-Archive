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
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		int GetNumGearWithName(string gearName);

		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		int GetMeasurableTotalByType(string type);
	}

	private const string START_FROM_RESTORE = "_startFromRestore";

	private const string START_BY_MISSION_JUMP = "_startByMissionJump";

	private static char[] m_FieldDividers;

	private static int tmpVarIndex;

	private static List<string> tagListsToRemove;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	public static Variable GetOrAddVar(IBlackboard bb, string name, Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public static Variable<T> GetOrAddVar<T>(IBlackboard bb, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 9)]
	public static bool SetInitialStateByTag(FSM fsm, string tag)
	{
		return default(bool);
	}

	[Calls(Type = typeof(FSM), Member = "EnterState")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static bool EnterStateByTag(FSM fsm, string tag)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnEnter")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GameObject SpawnChildGraph(GameObject prefab, GameObject parent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void AddBlackboardMembersIfRequired(IBlackboard source, IBlackboard dest)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public static T GetHostState<T>(ActionTask action, IBlackboard bb) where T : class
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	public static string GetSerializedBlackboard(Blackboard bb)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NCUtils), Member = "ProcessAssignmentString")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(NCUtils), Member = "ParseConditionalForCommandBlock")]
	[Calls(Type = typeof(NCUtils), Member = "TestConditional")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(Action_CommandBlock), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	public static string ProcessCommandBlockLines(IBlackboard blackboard, string[] lines, IBlackboard writeBlackboard = null)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_Message), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static string[] SubstituteVarsInStrings(IBlackboard blackboard, string[] lines)
	{
		return null;
	}

	[CalledBy(Type = typeof(NCUtils), Member = "GetValue4")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue4")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue3")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue3")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue4")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue3")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue4")]
	[CalledBy(Type = typeof(NCUtils), Member = "ParseConditional")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CalledBy(Type = typeof(NCUtils), Member = "ParseConditionalForCommandBlock")]
	[CallsUnknownMethods(Count = 56)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue2")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue2")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private static object GetValue(string val, bool allowListDecl = true)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static object GetValue2(string[] fields)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static object GetValue3(string[] fields)
	{
		return null;
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static object GetValue4(string[] fields)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(InventoryItemRequirement), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	private static object GetValue5(string[] fields)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	public static string ProcessAssignmentString(IBlackboard readBlackboard, IBlackboard writeBlackboard, string str, int eq)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static float SumMissionSelectionWeights(Dictionary<string, object>[] data)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	public static MissionManagerBase GetMissionManagerForFSM(IBlackboard blackboard)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string BuildFullStageName(string episode, string stage, string subStage, string worker1, string worker2)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(State_InvokeGraphBase), Member = "OnUpdate")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void LogStateInfo(string state, string info)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(InventoryItemRequirement), Member = "TestRequirementCondition")]
	[CalledBy(Type = typeof(Condition_ConditionBlock), Member = "BuildVarCache")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static bool ParseConditional(IBlackboard blackboard, string str, out Variable lhVar, out string op, out Variable rhVar)
	{
		lhVar = null;
		op = null;
		rhVar = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NCUtils), Member = "GetValue")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static bool ParseConditionalForCommandBlock(IBlackboard blackboard, string str, out Variable lhVar, out string op, out object rhVal)
	{
		lhVar = null;
		op = null;
		rhVal = null;
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(InventoryItemRequirement), Member = "TestRequirementCondition")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 33)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke")]
	public static bool TestConditional(Variable lhVar, string op, object rhVal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_get_game_state")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(BrokenRib), Member = "HasBrokenRib")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(TLD_CheckGameState), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(Condition), Member = "IsDegrading")]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	public static bool GetGameState(MissionGameState gameState)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	[CalledBy(Type = typeof(TLD_CheckContainerContains), Member = "OnCheck")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NCUtils), Member = "GetItemRequirementsMatchCount")]
	public static bool TestItemRequirements(Dictionary<string, List<InventoryItemRequirement>> requirementsDict, IItemRequirementsCollection collection, bool mustHaveAll, IBlackboard blackboard, ITaskSystem taskSystemOwner)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Action_GetInvRequirementsCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(NCUtils), Member = "TestItemRequirements")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(InventoryItemRequirement), Member = "TestRequirementCondition")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static int GetItemRequirementsMatchCount(Dictionary<string, List<InventoryItemRequirement>> requirementsDict, IItemRequirementsCollection collection, bool testAll, bool allowEarlyOut, IBlackboard blackboard, ITaskSystem taskSystemOwner)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Action_GetInvRequirementsCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TLD_CheckContainerContains), Member = "OnCheck")]
	public static Dictionary<string, List<InventoryItemRequirement>> BuildRequirementsDictionary(List<InventoryItemRequirement> reqItemList)
	{
		return null;
	}

	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "get_info")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLD_CheckContainerContains), Member = "get_info")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static bool IsValidRequirementIndex(List<InventoryItemRequirement> items, int index)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NCUtils()
	{
	}
}
