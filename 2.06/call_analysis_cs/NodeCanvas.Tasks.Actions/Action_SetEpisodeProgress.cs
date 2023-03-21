using System;
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
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 15)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public Action_SetEpisodeProgress()
	{
	}
}
