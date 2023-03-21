using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Interface.PanelRequest;

public class AsyncLoadPanelRequest : BaseLoadPanelRequest
{
	private string m_PanelVariantName;

	private AsyncOperationHandle<GameObject> m_AsyncRequest;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallsUnknownMethods(Count = 2)]
	public AsyncLoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void PanelInstantiated(AsyncOperationHandle<GameObject> panelHandle)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return default(float);
	}
}
