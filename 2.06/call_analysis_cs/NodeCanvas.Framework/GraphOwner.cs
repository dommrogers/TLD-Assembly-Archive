using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
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
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	public abstract IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	public abstract Type graphType
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	public bool isRunning
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public bool isPaused
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public float elapsedTime
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(GraphOwner), Member = "Start")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnEnable")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	public void StartBehaviour(bool autoUpdate, Action<bool> callback)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	public void PauseBehaviour()
	{
	}

	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnStop")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	public void StopBehaviour(bool success = true)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void UpdateBehaviour()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	public void RestartBehaviour()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_PlayerHoursPlayed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayerHPThreshold), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_IsInScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete")]
	[CallerCount(Count = 11)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	public void SendEvent(string eventName)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SendEvent<T>(string eventName, T eventValue)
	{
	}

	[CalledBy(Type = typeof(ShoutEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEventToObjects<>), Member = "OnExecute")]
	[CalledBy(Type = typeof(SendEventToObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(SendEvent<>), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SendEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph<>), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[CalledBy(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph), Member = "OnExecute")]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GraphOwner), Member = "Awake")]
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "Awake")]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "OnDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	protected void OnApplicationQuit()
	{
	}

	[CalledBy(Type = typeof(DialogueTreeController), Member = ".ctor")]
	[CalledBy(Type = typeof(FSMOwner), Member = ".ctor")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BehaviourTreeOwner), Member = ".ctor")]
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
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		set
		{
		}
	}

	public T behaviour
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	public sealed override IBlackboard blackboard
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public sealed override Type graphType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StartBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SwitchBehaviour(T newGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SwitchBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsUnknownMethods(Count = 1)]
	public void SwitchBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected GraphOwner()
	{
	}
}
