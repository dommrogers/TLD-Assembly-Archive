using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Help : Panel_Base
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
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHelpAction")]
	[CallerCount(Count = 1)]
	public void OnDone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Help()
	{
	}
}
