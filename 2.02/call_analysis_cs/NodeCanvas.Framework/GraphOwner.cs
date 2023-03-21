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
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	public abstract IBlackboard blackboard
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	public abstract Type graphType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public bool isRunning
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public bool isPaused
	{
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public float elapsedTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(float);
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GraphOwner), Member = "Initialize")]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
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

	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnEnable")]
	[CalledBy(Type = typeof(GraphOwner), Member = "Start")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__136), Member = "MoveNext")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	public void StartBehaviour(bool autoUpdate, Action<bool> callback)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void PauseBehaviour()
	{
	}

	[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnStop")]
	[CalledBy(Type = typeof(GraphOwnerControl), Member = "Do")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = "SwitchBehaviour")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(GraphOwner), Member = "OnDisable")]
	[CalledBy(Type = typeof(GraphOwner), Member = "RestartBehaviour")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Stop")]
	public void StopBehaviour(bool success = true)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	public void SendEvent(string eventName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 9)]
	public void SendEvent<T>(string eventName, T eventValue)
	{
	}

	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GraphOwner), Member = "Awake")]
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "Awake")]
	[Calls(Type = typeof(Graph), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "PauseBehaviour")]
	protected void OnDisable()
	{
	}

	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = "OnDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "GetAllInstancedNestedGraphs")]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnApplicationQuit()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DialogueTreeController), Member = ".ctor")]
	[CalledBy(Type = typeof(FSMOwner), Member = ".ctor")]
	[CalledBy(Type = typeof(GraphOwner<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(TLDBehaviourTreeOwner), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public sealed override IBlackboard blackboard
	{
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Graph), Member = "UpdateReferences")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 5)]
		set
		{
		}
	}

	public sealed override Type graphType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void StartBehaviour(T newGraph)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
