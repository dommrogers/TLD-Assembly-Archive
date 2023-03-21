using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_FailMission : ActionTask
{
	public BBParameter<LocalizedString> failureMessage;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public Action_FailMission()
	{
	}
}
