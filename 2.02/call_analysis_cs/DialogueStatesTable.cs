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

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetFirstStateKeyForState")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetFaceStateKeyForState")]
		[CalledBy(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
		[CallsUnknownMethods(Count = 21)]
		public string GetKey()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public DialogueStatesTableEntry()
		{
		}
	}

	public List<DialogueStatesTableEntry> m_DialogueStatesTableEntries;

	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 0)]
	public string GetLayer(string stateKey)
	{
		return null;
	}

	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 0)]
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
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallsUnknownMethods(Count = 4)]
	public string GetFirstStateKeyForState(string stateName)
	{
		return null;
	}

	[Calls(Type = typeof(DialogueStatesTableEntry), Member = "GetKey")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public string GetFaceStateKeyForState(string stateName)
	{
		return null;
	}

	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 0)]
	public bool HasKey(string stateKey)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 2)]
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
