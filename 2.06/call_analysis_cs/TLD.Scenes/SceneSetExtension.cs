using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Scenes;

public class SceneSetExtension : ScriptableObject
{
	private AssetReferenceT<SceneSet> m_ParentSceneSet;

	private List<AssetReference> m_AdditiveScenes;

	private List<ConditionalScene> m_ConditionalScenes;

	public List<AssetReference> AdditiveScenes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
	}

	public List<ConditionalScene> ConditionalScenes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SceneSetManager), Member = "HandleSceneExtensionLoaded")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle), Member = "get_IsDone")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public SceneSet GetParentSceneSet()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public SceneSetExtension()
	{
	}
}
