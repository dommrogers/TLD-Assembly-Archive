using Cpp2ILInjected.CallAnalysis;
using TLD.UI;

public class Panel_Help : Panel_AutoReferenced
{
	public bool m_EnablePauseMenuOnExit;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnDone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Panel_Help()
	{
	}
}
