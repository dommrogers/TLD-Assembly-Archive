using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Interface.PanelRequest;

public class AsyncLoadPanelRequest : BaseLoadPanelRequest
{
	private string m_PanelVariantName;

	private AsyncOperationHandle<GameObject> m_AsyncRequest;

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsUnknownMethods(Count = 1)]
	public AsyncLoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	private void PanelInstantiated(AsyncOperationHandle<GameObject> panelHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_PercentComplete")]
	public override float GetProgress()
	{
		return 0f;
	}
}
