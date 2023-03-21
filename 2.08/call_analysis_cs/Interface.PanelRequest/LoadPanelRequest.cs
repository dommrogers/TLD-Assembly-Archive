using Cpp2ILInjected.CallAnalysis;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace Interface.PanelRequest;

public class LoadPanelRequest : BaseLoadPanelRequest
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public LoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	public LoadPanelRequest(IResourceLocation resourceLocation)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return default(float);
	}
}
