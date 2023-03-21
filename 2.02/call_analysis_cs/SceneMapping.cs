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
		[CallerCount(Count = 2)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ChildSceneEntry()
		{
		}
	}

	public List<ParentSceneEntry> m_ParentSceneList;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public bool ChildExperienceModeMatches(ParentSceneEntry entry, LayerMask xpMode, int childIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallsUnknownMethods(Count = 5)]
	public ParentSceneEntry GetParentChildEntryNoCase(string parentName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "GetMapNameOfScene")]
	[CalledBy(Type = typeof(SceneMapping), Member = "IsSceneOutdoor")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	public ParentSceneEntry GetParentSceneEntry(string parentName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
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
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public bool IsSceneOutdoor(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public SceneMapping()
	{
	}
}
