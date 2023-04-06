using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowCredits : ActionTask
{
	public int m_CreditsSourceIndex;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 1)]
	private static void SimpleQuit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ShowCredits()
	{
	}
}
