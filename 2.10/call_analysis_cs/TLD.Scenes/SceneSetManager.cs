using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Logging;
using TLD.OptionalContent;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace TLD.Scenes;

public static class SceneSetManager
{
	public static LogFilter s_LogFilter;

	private static bool m_IsInitialized;

	private static List<SceneSet> m_ExtendedSceneSets;

	[CalledBy(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SceneSetManager), Member = "HandleOnOptionalContentLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void InitializeSceneSetManager()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	public static SceneSet FindSceneSetForSceneName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SceneSetManager), Member = "InitializeSceneSetManager")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	public static SceneSet FindSceneSetForSceneName(string name, bool warnIfNotAvailable)
	{
		return null;
	}

	[CalledBy(Type = typeof(SceneSetManager), Member = "InitializeSceneSetManager")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "LoadAssetsInOptionalContent")]
	[Calls(Type = typeof(SceneSetManager), Member = "HandleSceneExtensionLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void HandleOnOptionalContentLoaded(IResourceLocator optionalContentLocator)
	{
	}

	[CalledBy(Type = typeof(SceneSetManager), Member = "HandleOnOptionalContentLoaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneSetExtension), Member = "GetParentSceneSet")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static void HandleSceneExtensionLoaded(SceneSetExtension sceneSetExtension)
	{
	}
}
