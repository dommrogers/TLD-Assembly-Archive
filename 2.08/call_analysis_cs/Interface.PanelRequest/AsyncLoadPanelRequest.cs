using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Interface.PanelRequest;

public class AsyncLoadPanelRequest : BaseLoadPanelRequest
{
	private string m_PanelVariantName;

	private AsyncOperationHandle<GameObject> m_AsyncRequest;

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AsyncLoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void PanelInstantiated(AsyncOperationHandle<GameObject> panelHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override float GetProgress()
	{
		return default(float);
	}
}
