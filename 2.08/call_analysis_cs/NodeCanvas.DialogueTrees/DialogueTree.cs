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
			[CallerCount(Count = 80)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 279)]
			set
			{
			}
		}

		public string ID
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
			[Calls(Type = typeof(Guid), Member = "ToString")]
			get
			{
				return null;
			}
		}

		public IDialogueActor actor
		{
			[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
			[CalledBy(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 3)]
			[CalledBy(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
			get
			{
				return null;
			}
			[CalledBy(Type = typeof(DialogueTree), Member = "SetActorReferences")]
			[CalledBy(Type = typeof(DialogueTree), Member = "SetActorReference")]
			[CalledBy(Type = typeof(ActorParameter), Member = ".ctor")]
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
		[CallerCount(Count = 279)]
		public ActorParameter(string name)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActorParameter), Member = "set_actor")]
		public ActorParameter(string name, IDialogueActor actor)
		{
		}

		[CallerCount(Count = 80)]
		[DeduplicatedMethod]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003CGetParameterByID_003Eb__0(ActorParameter p)
		{
			return default(bool);
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
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetParameterByName_003Eb__0(ActorParameter p)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public string paramName;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool _003CGetActorReferenceByName_003Eb__0(ActorParameter r)
		{
			return default(bool);
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

		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CSetActorReference_003Eb__0(ActorParameter p)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public KeyValuePair<string, IDialogueActor> pair;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass51_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		internal bool _003CSetActorReferences_003Eb__0(ActorParameter p)
		{
			return default(bool);
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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
			return default(bool);
		}
	}

	public override bool requiresPrimeNode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool isTree
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public override bool useLocalBlackboard
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public sealed override bool canAcceptVariableDrops
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public List<ActorParameter> actorParameters
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
	}

	public List<string> definedActorParameterNames
	{
		[CalledBy(Type = typeof(DTNode), Member = "get_name")]
		[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static event Action<DialogueTree> OnDialogueStarted
	{
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<DialogueTree> OnDialoguePaused
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<DialogueTree> OnDialogueFinished
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest
	{
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
	{
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(DialogueUGUI), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
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

	[CalledBy(Type = typeof(DTNode), Member = "get_finalActor")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DTNode), Member = "get_actorName")]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[CalledBy(Type = typeof(DTNode), Member = "get_name")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_actorName")]
	[CalledBy(Type = typeof(DTNode), Member = "get_name")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_finalActor")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	public ActorParameter GetParameterByID(string id)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "set_actorName")]
	[CalledBy(Type = typeof(DTNode), Member = "set_actorName")]
	[CallsUnknownMethods(Count = 1)]
	public ActorParameter GetParameterByName(string paramName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public IDialogueActor GetActorReferenceByID(string id)
	{
		return null;
	}

	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(DTNode), Member = "get_finalActor")]
	[CalledBy(Type = typeof(DTNode), Member = "get_finalActor")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "GetActorReferenceByName")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_finalActor")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = "get_finalActor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ActorParameter), Member = "get_actor")]
	[Calls(Type = typeof(ActorParameter), Member = "get_actor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	public IDialogueActor GetActorReferenceByName(string paramName)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueTreeController), Member = "SetActorReference")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SubDialogueTree), Member = "SetActorParametersMapping")]
	[Calls(Type = typeof(ActorParameter), Member = "set_actor")]
	[CallsUnknownMethods(Count = 1)]
	public void SetActorReference(string paramName, IDialogueActor actor)
	{
	}

	[CalledBy(Type = typeof(DialogueTreeController), Member = "SetActorReferences")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActorParameter), Member = "set_actor")]
	public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 26)]
	public void Continue(int index = 0)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GoToNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Jumper), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueTree), Member = "OnGraphUnpaused")]
	[CalledBy(Type = typeof(DialogueTree), Member = "OnGraphStarted")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public void EnterNode(DTNode node)
	{
	}

	[CalledBy(Type = typeof(Say), Member = "OnExecute")]
	[CalledBy(Type = typeof(StatementNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(SayRandom), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	public static void RequestSubtitles(SubtitlesRequestInfo info)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	public static void RequestMultipleChoices(MultipleChoiceRequestInfo info)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnGraphUnpaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	protected override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public DialogueTree()
	{
	}
}
