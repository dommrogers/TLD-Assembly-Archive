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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	public string GetLocalizedSceneName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LoadingScreenInfo()
	{
	}
}
