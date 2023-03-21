using Cpp2ILInjected.CallAnalysis;
using TLD.UI;

public class Panel_Help : Panel_AutoReferenced
{
	public bool m_EnablePauseMenuOnExit;

	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	private void ExitInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Help()
	{
	}
}
