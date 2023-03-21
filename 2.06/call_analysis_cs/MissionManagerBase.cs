using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
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

	[CalledBy(Type = typeof(MainMissionManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SideMissionManager), Member = ".ctor")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Awake")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	protected MissionManagerBase(string missionId, FSMOwner fsmOwner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsUnknownMethods(Count = 2)]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public void InitiateJumpTo(string[] jumpToIds, FSMHierarchy.Rank firstRank, string missionConfigData)
	{
	}

	[CalledBy(TypeFullName = "MissionServicesManager.<JumpCo>d__130", Member = "MoveNext")]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void PreRegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void RegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void UnregisterChildGraph(FSMHierarchy.Rank rank)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public void FlushDeserializeData()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public bool GetMissionBlackboardVar<T>(string varName, out T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
		value = default(T);
		return false;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 23)]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryGetMissionBlackboardVar")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 23)]
	public bool TryGetBlackboardVarAsFloatFullSearch(string varName, out float result)
	{
		result = default(float);
		return false;
	}
}
