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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public Entry()
		{
		}
	}

	public List<Entry> m_Entries;

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public StringTableData()
	{
	}
}
