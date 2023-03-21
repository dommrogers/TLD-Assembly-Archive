using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion;
using UnityEngine;

public class FSMHierarchy
{
	public enum Rank
	{
		Episode,
		Stage,
		SubStage,
		Worker1,
		Worker2,
		Worker3,
		Max
	}

	internal string[] m_RankIds;

	internal FSM[] m_FSMs;

	internal GraphOwner[] m_ChildGraphs;

	public string Episode
	{
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public string Stage
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public string SubStage
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public string Worker1
	{
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public string Worker2
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public string Worker3
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void ValidateTag(FSM fsm)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterFSM")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterChildGraph")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__136), Member = "MoveNext")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SetChildGraphForRank")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	public void SetFSMForRank(Rank rank, FSM fsm)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetChildGraphForRank(Rank rank, GraphOwner graphOwner)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	public string GetJumpString()
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RefreshMissionIds")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	public void RefreshIds()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	public void Stop()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void SendEvent(EventData ev)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SendEvent(string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	public void SendEvent<T>(string eventString, T value)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = ".ctor")]
	public FSMHierarchy()
	{
	}
}
