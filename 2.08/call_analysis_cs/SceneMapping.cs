using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneMapping : ScriptableObject
{
	[Serializable]
	public class ParentSceneEntry
	{
		public string m_ParentName;

		public bool m_IsOutdoor;

		public bool m_IsTestScene;

		public string m_MapName;

		public bool m_UseMapNameInStory;

		public bool m_UseMapNameInSurvival;

		public int m_SwitchBoostResolutionOverride;

		public List<ChildSceneEntry> m_ChildList;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ParentSceneEntry()
		{
		}
	}

	[Serializable]
	public class ChildSceneEntry
	{
		public string m_ChildName;

		public string m_Suffix;

		public bool m_MissionLayer;

		public LayerMask m_ExperienceModeMask;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public ChildSceneEntry()
		{
		}
	}

	public List<ParentSceneEntry> m_ParentSceneList;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool ChildExperienceModeMatches(ParentSceneEntry entry, LayerMask xpMode, int childIndex)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 0)]
	public ParentSceneEntry GetParentChildEntryNoCase(string parentName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SceneMapping), Member = "IsSceneOutdoor")]
	[CallsUnknownMethods(Count = 6)]
	public ParentSceneEntry GetParentSceneEntry(string parentName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public string GetParentNameFromScene(string sceneName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	public bool IsSceneOutdoor(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SceneMapping()
	{
	}
}
