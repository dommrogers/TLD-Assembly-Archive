using System;
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public string Stage
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

	public string Worker2
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void ValidateTag(FSM fsm)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterChildGraph")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "RegisterFSM")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SetChildGraphForRank")]
	public void SetFSMForRank(Rank rank, FSM fsm)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RefreshMissionIds")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void RefreshIds()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 2)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 2)]
	public void SendEvent(EventData ev)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionServicesManager._003CPostSceneLoadCo_003Ed__109), Member = "MoveNext")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	public void SendEvent(string eventString)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SendEvent<T>(string eventString, T value)
	{
	}

	[CallerCount(Count = 0)]
	public FSMHierarchy()
	{
	}
}
