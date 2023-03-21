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

	[CalledBy(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void ValidateTag(FSM fsm)
	{
	}

	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterFSM")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterChildGraph")]
	[CalledBy(TypeFullName = "MissionServicesManager.<JumpCo>d__136", Member = "MoveNext")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SetChildGraphForRank")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	public void SetFSMForRank(Rank rank, FSM fsm)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void SetChildGraphForRank(Rank rank, GraphOwner graphOwner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string GetJumpString()
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RefreshMissionIds")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void RefreshIds()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void SendEvent(EventData ev)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void SendEvent(string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void SendEvent<T>(string eventString, T value)
	{
	}

	[CalledBy(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FSMHierarchy()
	{
	}
}
