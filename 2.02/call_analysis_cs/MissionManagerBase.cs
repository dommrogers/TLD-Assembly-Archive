using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion;
using UnityEngine;

public abstract class MissionManagerBase
{
	public FSMOwner m_FSMOwner;

	public string m_MissionId;

	public FSMHierarchy m_FSMHierarchy;

	public string[] m_JumpToIds;

	public bool m_IsActive;

	public bool m_WasCompleted;

	private int m_NextIdIndex;

	private int m_NextFSMIndex;

	private static int m_NextId;

	public int m_MyId;

	private MissionManagerSaveProxy m_DeserializeData;

	private static MissionManagerSaveProxy m_MissionManagerSaveProxy;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FSMHierarchy), Member = ".ctor")]
	[CalledBy(Type = typeof(MainMissionManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SideMissionManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	protected MissionManagerBase(string missionId, FSMOwner fsmOwner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(Type = typeof(FSMHierarchy), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void InitiateJumpTo(string[] jumpToIds, FSMHierarchy.Rank firstRank, string missionConfigData)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__136), Member = "MoveNext")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 4)]
	public string GetNextJumpToId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public FSMHierarchy.Rank AssignFSMRank()
	{
		return default(FSMHierarchy.Rank);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void PreRegisterGraphOwner(GraphOwner graphOwner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterFSM(FSMHierarchy.Rank rank, FSM fsm, GraphOwner graphOwner = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UnregisterFSM(FSMHierarchy.Rank rank)
	{
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	public void PreRegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsUnknownMethods(Count = 7)]
	public void RegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void UnregisterChildGraph(FSMHierarchy.Rank rank)
	{
	}

	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void FlushDeserializeData()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "threedaysofnight_completetimer")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void SendMissionEvent(string eventString)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 9)]
	public void SendMissionEvent(EventData ev)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SendMissionEvent<T>(string eventString, T value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetTopLevelBlackboardVar<T>(string varName, T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void SetMissionBlackboardVar<T>(string varName, T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsUnknownMethods(Count = 13)]
	public bool GetMissionBlackboardVar<T>(string varName, out T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public bool TryGetBlackboardVarAsFloatFullSearch(string varName, out float result)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref result) = null;
		return default(bool);
	}
}
