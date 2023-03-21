using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion;
using TLD.Serialization;
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Awake")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[CalledBy(Type = typeof(MainMissionManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SideMissionManager), Member = ".ctor")]
	[CallerCount(Count = 4)]
	protected MissionManagerBase(string missionId, FSMOwner fsmOwner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	public void InitiateJumpTo(string[] jumpToIds, FSMHierarchy.Rank firstRank, string missionConfigData)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public string GetNextJumpToId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public FSMHierarchy.Rank AssignFSMRank()
	{
		return default(FSMHierarchy.Rank);
	}

	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 2)]
	public void UnregisterFSM(FSMHierarchy.Rank rank)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void PreRegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsUnknownMethods(Count = 5)]
	public void RegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void UnregisterChildGraph(FSMHierarchy.Rank rank)
	{
	}

	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void FlushDeserializeData()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	public void SendMissionEvent(string eventString)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void SendMissionEvent(EventData ev)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SendMissionEvent<T>(string eventString, T value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetTopLevelBlackboardVar<T>(string varName, T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SetMissionBlackboardVar<T>(string varName, T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public bool GetMissionBlackboardVar<T>(string varName, out T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
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
