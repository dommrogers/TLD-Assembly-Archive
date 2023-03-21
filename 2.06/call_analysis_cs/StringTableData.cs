using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StringTableData : ScriptableObject
{
	public enum EntryFlags
	{
		None,
		NeedsTranslation
	}

	[Serializable]
	public class Entry
	{
		public string m_Key;

		public List<string> m_Languages;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public Entry()
		{
		}
	}

	public List<Entry> m_Entries;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StringTableData()
	{
	}
}
