using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneNameMapping : ScriptableObject
{
	[Serializable]
	public class SceneNameMapEntry
	{
		public string m_SceneName;

		public string m_LocId;

		public string m_Region;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SceneNameMapEntry()
		{
		}
	}

	private List<SceneNameMapEntry> m_Scenes;

	private Dictionary<string, string> m_SceneNameMapping;

	private Dictionary<string, string> m_SceneRegionMapping;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static string FindLocalizedSceneNamesPath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static SceneNameMapping GetRefOrLoad(string sceneNamesFilePath = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	public string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void AddEntry(string sceneName)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public void AddEntry(string sceneName, string locId, string region)
	{
	}

	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CalledBy(Type = typeof(SceneNameMapping), Member = "GetLocIDForScene")]
	[CalledBy(Type = typeof(SceneNameMapping), Member = "GetRegionForScene")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	public static bool IsChildOfAnother(string sceneName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public SceneNameMapping()
	{
	}
}
