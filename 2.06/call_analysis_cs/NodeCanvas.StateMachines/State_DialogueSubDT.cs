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
		[CallerCount(Count = 3)]
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
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(State_DialogueSubDT), Member = "GetDialogModeRigFPOnActor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NCUtils), Member = "SpawnChildGraph")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected override void OnEnter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	protected override void OnExit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "AddBlackboardMembersIfRequired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	private void StartDialogueTree()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 2)]
	private DialogueModeRigFP GetDialogModeRigFPOnActor(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public State_DialogueSubDT()
	{
	}
}
