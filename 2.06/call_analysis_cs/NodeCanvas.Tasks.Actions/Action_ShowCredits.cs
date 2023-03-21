using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowCredits : ActionTask
{
	public int m_CreditsSourceIndex;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallsUnknownMethods(Count = 1)]
	private static void SimpleQuit()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_ShowCredits()
	{
	}
}
