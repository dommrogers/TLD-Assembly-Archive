using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Stats;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetEpisodeProgress : ActionTask
{
	public BBParameter<int> m_EpisodeProgress;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Action_SetEpisodeProgress()
	{
	}
}
