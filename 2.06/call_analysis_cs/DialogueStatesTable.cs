using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueStatesTable : ScriptableObject
{
	[Serializable]
	public class DialogueStatesTableEntry
	{
		public string m_AnimatorType;

		public string m_BundlePath;

		public string m_PrefabPath;

		public string m_LayerName;

		public int m_LayerIndex;

		public string m_State;

		public string m_TriggeredBy;

		public string m_TriggerIdle;

		public string m_StateIdle;

		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetFirstStateKeyForState")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetFaceStateKeyForState")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(Path), Member = "ChangeExtension")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 21)]
		public string GetKey()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public DialogueStatesTableEntry()
		{
		}
	}

	public List<DialogueStatesTableEntry> m_DialogueStatesTableEntries;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetLayer(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetTriggeredBy(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetTriggerIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetStateIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public int GetLayerIndex(string stateKey)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetPrefabPath(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetAnimationState(string stateKey)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[CallsUnknownMethods(Count = 4)]
	public string GetFirstStateKeyForState(string stateName)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[CallsUnknownMethods(Count = 3)]
	public string GetFaceStateKeyForState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public bool HasKey(string stateKey)
	{
		return false;
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private DialogueStatesTableEntry GetListEntryFromStateKey(string stateKey)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DialogueStatesTable()
	{
	}
}
