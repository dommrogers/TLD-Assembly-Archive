using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace Interface.PanelRequest;

public class LoadPanelRequest : BaseLoadPanelRequest
{
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Addressables), Member = "LoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsUnknownMethods(Count = 2)]
	public LoadPanelRequest(IResourceLocation resourceLocation)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return 0f;
	}
}
