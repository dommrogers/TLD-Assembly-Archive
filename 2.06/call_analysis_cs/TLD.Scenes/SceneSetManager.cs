using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using TLD.OptionalContent;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace TLD.Scenes;

public static class SceneSetManager
{
	public static LogFilter s_LogFilter;

	private static bool m_IsInitialized;

	private static List<SceneSet> m_ExtendedSceneSets;

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(SceneSetManager), Member = "HandleOnOptionalContentLoaded")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	public static void InitializeSceneSetManager()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	public static SceneSet FindSceneSetForSceneName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(SceneSetManager), Member = "InitializeSceneSetManager")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	public static SceneSet FindSceneSetForSceneName(string name, bool warnIfNotAvailable)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CalledBy(Type = typeof(SceneSetManager), Member = "InitializeSceneSetManager")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SceneSetManager), Member = "HandleSceneExtensionLoaded")]
	private static void HandleOnOptionalContentLoaded(IResourceLocator optionalContentLocator)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SceneSetExtension), Member = "GetParentSceneSet")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(SceneSetManager), Member = "HandleOnOptionalContentLoaded")]
	private static void HandleSceneExtensionLoaded(SceneSetExtension sceneSetExtension)
	{
	}
}
