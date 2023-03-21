using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Scenes;

public class UIWorldMap : MonoBehaviour
{
	private AssetReferenceTexture2D m_MapTexture;

	private UITexture m_target;

	private AsyncOperationHandle<Texture2D> m_asyncOp;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWorldMap), Member = "LoadMap")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(UIWorldMap), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void LoadMap()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIWorldMap()
	{
	}
}
