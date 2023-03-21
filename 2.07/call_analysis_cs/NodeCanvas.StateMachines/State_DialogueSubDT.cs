using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class State_DialogueSubDT : FSMState, ITaskAssignable, ITLDChildGraphOwner
{
	public string actorName;

	public BBParameter<GameObject> childDialogueTreePrefab;

	public bool trustDialogue;

	public bool groundPlayerOnEnd;

	private ActionList _actionList;

	private bool _repeatStateActions;

	private GameObject childGraphObject;

	private Graph childGraph;

	private DialogueTreeController dialogTreeController;

	private DialogueModeRigFP m_DialogueModeRigFP;

	private int m_RetryOnEnterCounter;

	private bool m_DoRetryOnEnter;

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ActionList actionList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		set
		{
		}
	}

	public bool repeatStateActions
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public GameObject childGraphPrefab
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnValidate(Graph assignedGraph)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NCUtils), Member = "SpawnChildGraph")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State_DialogueSubDT), Member = "GetDialogModeRigFPOnActor")]
	protected override void OnEnter()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnEnter")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "AddBlackboardMembersIfRequired")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	private void StartDialogueTree()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnEnter")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private DialogueModeRigFP GetDialogModeRigFPOnActor(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public State_DialogueSubDT()
	{
	}
}
