using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowCredits : ActionTask
{
	public int m_CreditsSourceIndex;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	private static void SimpleQuit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ShowCredits()
	{
	}
}
