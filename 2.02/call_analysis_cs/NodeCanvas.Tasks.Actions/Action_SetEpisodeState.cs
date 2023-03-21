using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetEpisodeState : ActionTask
{
	public Episode episode;

	public EpisodeState state;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetEpisodeState()
	{
	}
}
