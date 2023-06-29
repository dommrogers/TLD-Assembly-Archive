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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void AddEntry(string sceneName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void AddEntry(string sceneName, string locId, string region)
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CalledBy(Type = typeof(SceneNameMapping), Member = "GetLocIDForScene")]
	[CalledBy(Type = typeof(SceneNameMapping), Member = "GetRegionForScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsChildOfAnother(string sceneName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public SceneNameMapping()
	{
	}
}
