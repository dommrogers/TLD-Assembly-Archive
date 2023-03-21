using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class LoadingScreenInfo
{
	public List<AsyncOperationHandle<SceneInstance>> m_AsyncOperations;

	public string m_MainScene;

	public SceneSet m_SceneSet;

	public string m_Region;

	public string m_Mission;

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetLocalizedSceneName()
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public LoadingScreenInfo()
	{
	}
}
