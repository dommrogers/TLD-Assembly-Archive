using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

public abstract class GraphOwner : MonoBehaviour
{
	public enum EnableAction
	{
		EnableBehaviour,
		DoNothing
	}

	public enum DisableAction
	{
		DisableBehaviour,
		PauseBehaviour,
		DoNothing
	}

	private string boundGraphSerialization;

	private List<UnityEngine.Object> boundGraphObjectReferences;

	public EnableAction enableAction;

	public DisableAction disableAction;

	public static Action<GraphOwner> onOwnerBehaviourStateChange;

	private Dictionary<Graph, Graph> instances;

	private bool initialized;

	private bool startCalled;

	private static bool isQuiting;

	public abstract Graph graph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}

	public abstract IBlackboard blackboard
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}

	public abstract Type graphType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	public bool isRunning
	{
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public bool isPaused
	{
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public float elapsedTime
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallsUnknownMethods(Count = 2)]
	public Graph GetInstance(Graph originalGraph)
	{
		return null;
	}

	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallerCount(Count = 0)]
	public void StartBehaviour()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartBehaviour(Action<bool> callback)
	{
	}

	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Start")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnEnable")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	public void StartBehaviour(bool autoUpdate, Action<bool> callback)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	public void PauseBehaviour()
	{
	}

	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnStop")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	public void StopBehaviour(bool success = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateBehaviour()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	public void RestartBehaviour()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_PlayerHoursPlayed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayerHPThreshold), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_IsInScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CalledBy(Type = typeof(MissionServicesManager._003CPostSceneLoadCo_003Ed__109), Member = "MoveNext")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete")]
	[CallerCount(Count = 13)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	public void SendEvent(string eventName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SendEvent<T>(string eventName, T eventValue)
	{
	}

	[CalledBy(Type = typeof(SendEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEventToObjects<>), Member = "OnExecute")]
	[CalledBy(Type = typeof(ShoutEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEventToObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(SendEvent<>), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph<>), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph), Member = "OnExecute")]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GraphOwner), Member = "Awake")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "Awake")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "Initialize")]
	protected virtual void Awake()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallerCount(Count = 0)]
	protected void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	protected void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	protected void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "OnDestroy")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	protected void OnApplicationQuit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected GraphOwner()
	{
	}
}
public abstract class GraphOwner<T> : GraphOwner where T : Graph
{
	private T _graph;

	private UnityEngine.Object _blackboard;

	public sealed override Graph graph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public T behaviour
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		set
		{
		}
	}

	public sealed override IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	public sealed override Type graphType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StartBehaviour(T newGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StartBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void StartBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SwitchBehaviour(T newGraph)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SwitchBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SwitchBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected GraphOwner()
	{
	}
}
