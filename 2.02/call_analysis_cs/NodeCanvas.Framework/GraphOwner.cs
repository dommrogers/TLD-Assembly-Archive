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

	public abstract Graph graph { get; set; }

	public abstract IBlackboard blackboard { get; set; }

	public abstract Type graphType { get; }

	public bool isRunning
	{
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool isPaused
	{
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public float elapsedTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Dictionary<, >), Member = "ContainsValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Graph), Member = "Clone")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public Graph GetInstance(Graph originalGraph)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	public void StartBehaviour()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartBehaviour(Action<bool> callback)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Start")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(TypeFullName = "MissionServicesManager.<JumpCo>d__136", Member = "MoveNext")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnEnable")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Start")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void StartBehaviour(bool autoUpdate, Action<bool> callback)
	{
	}

	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void PauseBehaviour()
	{
	}

	[CalledBy(Type = typeof(MissionManagerBase), Member = "Stop")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnStop")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void StopBehaviour(bool success = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateBehaviour()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	public void RestartBehaviour()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallerCount(Count = 3)]
	public void SendEvent(string eventName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void SendEvent<T>(string eventName, T eventValue)
	{
	}

	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateMissionInfo")]
	[CalledBy(Type = typeof(Action_ChallengeNowhereToHideRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph<>), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayerHPThreshold), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayerHoursPlayed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_IsInScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(SendEvent), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEvent<>), Member = "OnUpdate")]
	[CalledBy(Type = typeof(SendEventToObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(SendEventToObjects<>), Member = "OnExecute")]
	[CalledBy(Type = typeof(ShoutEvent), Member = "OnUpdate")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "Awake")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 6)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "Initialize")]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnDisable()
	{
	}

	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnApplicationQuit()
	{
	}

	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = ".ctor")]
	[CalledBy(Type = typeof(BehaviourTreeOwner), Member = ".ctor")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = ".ctor")]
	[CalledBy(Type = typeof(FSMOwner), Member = ".ctor")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
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
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public T behaviour
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public sealed override IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public sealed override Type graphType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StartBehaviour(T newGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StartBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StartBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SwitchBehaviour(T newGraph)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SwitchBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SwitchBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	protected GraphOwner()
	{
	}
}
