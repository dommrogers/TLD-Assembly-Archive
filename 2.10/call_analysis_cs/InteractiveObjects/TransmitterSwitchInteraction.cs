using Cpp2ILInjected.CallAnalysis;

namespace InteractiveObjects;

public class TransmitterSwitchInteraction : OpenClose
{
	public LocalizedString m_LocalizedCantOpenHandle;

	private Transmitter m_Transmitter;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "PerformHold")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformHold()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TransmitterSwitchInteraction()
	{
	}
}
