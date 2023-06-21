using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using UnityEngine;

namespace TLD.Transmitters.UI;

public class TransmitterSiteMapItem : MonoBehaviour
{
	private UISprite m_RepairedSprite;

	private UISprite m_UnrepairedSprite;

	private UISprite m_BackgroundSprite;

	private UISprite m_HoverSprite;

	[CalledBy(TypeFullName = "TLD.Transmitters.UI.TransmitterSiteUIController.<>c__DisplayClass23_0", Member = "<MaybeSetupTransmitterMapItem>b__0")]
	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "MaybeSetupTransmitterMapItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void SetTransmitter(TransmitterData transmitter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TransmitterSiteMapItem()
	{
	}
}
