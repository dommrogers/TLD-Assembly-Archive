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
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string Stage
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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
		[CallsUnknownMethods(Count = 2)]
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
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string Worker2
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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
		[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void ValidateTag(FSM fsm)
	{
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterFSM")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterChildGraph")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SetChildGraphForRank")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 9)]
	public void SetFSMForRank(Rank rank, FSM fsm)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetChildGraphForRank(Rank rank, GraphOwner graphOwner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public string GetJumpString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RefreshMissionIds")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void RefreshIds()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 2)]
	public void Stop()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public void SendEvent(EventData ev)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	public void SendEvent(string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public void SendEvent<T>(string eventString, T value)
	{
	}

	[CallerCount(Count = 0)]
	public FSMHierarchy()
	{
	}
}
