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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Entry()
		{
		}
	}

	public List<Entry> m_Entries;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public StringTableData()
	{
	}
}
