using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees.UI.Examples;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class DialogueTree : Graph
{
	[Serializable]
	private struct DerivedSerializationData
	{
		public List<ActorParameter> actorParameters;
	}

	[Serializable]
	public class ActorParameter
	{
		private string _keyName;

		private string _id;

		private UnityEngine.Object _actorObject;

		[NonSerialized]
		private IDialogueActor _actor;

		public string name
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 92)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 281)]
			set
			{
			}
		}

		public string ID
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
			[Calls(TypeFullName = "Interop", Member = "GetRandomBytes")]
			[Calls(Type = typeof(Guid), Member = "ToString")]
			get
			{
				return null;
			}
		}

		public IDialogueActor actor
		{
			[CalledBy(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
			[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return null;
			}
			[CalledBy(Type = typeof(ActorParameter), Member = ".ctor")]
			[CalledBy(Type = typeof(DialogueTree), Member = "SetActorReference")]
			[CalledBy(Type = typeof(DialogueTree), Member = "SetActorReferences")]
			[CallerCount(Count = 3)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ActorParameter()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 281)]
		public ActorParameter(string name)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActorParameter), Member = "set_actor")]
		public ActorParameter(string name, IDialogueActor actor)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 92)]
		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ActorParameter, string> _003C_003E9__45_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003Cget_definedActorParameterNames_003Eb__45_0(ActorParameter r)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public string id;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetParameterByID_003Eb__0(ActorParameter p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public string paramName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetParameterByName_003Eb__0(ActorParameter p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public string paramName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetActorReferenceByName_003Eb__0(ActorParameter r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public string paramName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass50_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CSetActorReference_003Eb__0(ActorParameter p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public KeyValuePair<string, IDialogueActor> pair;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass51_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CSetActorReferences_003Eb__0(ActorParameter p)
		{
			return false;
		}
	}

	public const string INSTIGATOR_NAME = "INSTIGATOR";

	private List<ActorParameter> _actorParameters;

	private DTNode currentNode;

	private static DialogueTree _003CcurrentDialogue_003Ek__BackingField;

	private static DialogueTree _003CpreviousDialogue_003Ek__BackingField;

	public static DialogueTree currentDialogue
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static DialogueTree previousDialogue
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public override Type baseNodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public override bool requiresAgent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return false;
		}
	}

	public override bool requiresPrimeNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public override bool isTree
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public override bool useLocalBlackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return false;
		}
	}

	public sealed override bool canAcceptVariableDrops
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return false;
		}
	}

	public List<ActorParameter> actorParameters
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 64)]
		get
		{
			return null;
		}
	}

	public List<string> definedActorParameterNames
	{
		[CalledBy(Type = typeof(DTNode), Member = "get_name")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Select")]
		[Calls(Type = typeof(List<>), Member = "Insert")]
		[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	public static event Action<DialogueTree> OnDialogueStarted
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<DialogueTree> OnDialoguePaused
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<DialogueTree> OnDialogueFinished
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	public override object OnDerivedDataSerialization()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnDerivedDataDeserialization(object data)
	{
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_actorName")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_finalActor")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(DTNode), Member = "get_name")]
	[CalledBy(Type = typeof(DTNode), Member = "get_actorName")]
	[CalledBy(Type = typeof(DTNode), Member = "get_finalActor")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ActorParameter GetParameterByID(string id)
	{
		return null;
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "set_actorName")]
	[CalledBy(Type = typeof(DTNode), Member = "set_actorName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ActorParameter GetParameterByName(string paramName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public IDialogueActor GetActorReferenceByID(string id)
	{
		return null;
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_finalActor")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "GetActorReferenceByName")]
	[CalledBy(Type = typeof(DTNode), Member = "get_finalActor")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CallerCount(Count = 11)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(ActorParameter), Member = "get_actor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public IDialogueActor GetActorReferenceByName(string paramName)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueTreeController), Member = "SetActorReference")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(ActorParameter), Member = "set_actor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetActorReference(string paramName, IDialogueActor actor)
	{
	}

	[CalledBy(Type = typeof(DialogueTreeController), Member = "SetActorReferences")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ActorParameter), Member = "set_actor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 26)]
	public void Continue(int index = 0)
	{
	}

	[CalledBy(Type = typeof(DialogueTree), Member = "OnGraphStarted")]
	[CalledBy(Type = typeof(DialogueTree), Member = "OnGraphUnpaused")]
	[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
	[CalledBy(Type = typeof(GoToNode), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void EnterNode(DTNode node)
	{
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(StatementNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Say), Member = "OnExecute")]
	[CalledBy(Type = typeof(SayRandom), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestSubtitles(SubtitlesRequestInfo info)
	{
	}

	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestMultipleChoices(MultipleChoiceRequestInfo info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphUnpaused()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DialogueTree()
	{
	}
}
