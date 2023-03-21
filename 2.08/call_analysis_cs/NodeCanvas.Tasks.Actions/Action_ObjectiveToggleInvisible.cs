using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ObjectiveToggleInvisible : ActionTask
{
	public BBParameter<string> objectiveID;

	public BBParameter<bool> invisible;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(Utils), Member = "ObjectiveIDExists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Action_ObjectiveToggleInvisible()
	{
	}
}
