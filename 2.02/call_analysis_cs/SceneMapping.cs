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
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 7)]
		public ChildSceneEntry()
		{
		}
	}

	public List<ParentSceneEntry> m_ParentSceneList;

	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool ChildExperienceModeMatches(ParentSceneEntry entry, LayerMask xpMode, int childIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "MaybeLateLoadMissionLayers")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public ParentSceneEntry GetParentChildEntryNoCase(string parentName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[CalledBy(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[CalledBy(Type = typeof(GameManager), Member = "GetMapNameOfScene")]
	[CalledBy(Type = typeof(SceneMapping), Member = "IsSceneOutdoor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSceneOutdoor(string sceneName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SceneMapping()
	{
	}
}
