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

		[CallsUnknownMethods(Count = 21)]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetFaceStateKeyForState")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetFirstStateKeyForState")]
		[Calls(Type = typeof(Path), Member = "ChangeExtension")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Format")]
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

	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 0)]
	public int GetLayerIndex(string stateKey)
	{
		return default(int);
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public string GetFirstStateKeyForState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallsUnknownMethods(Count = 3)]
	public string GetFaceStateKeyForState(string stateName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public bool HasKey(string stateKey)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
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
