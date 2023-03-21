using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_QueueLoadScreenHint : ActionTask
{
	public BBParameter<string> locID;

	public BBParameter<string> titleLocID;

	private const int LOC_PREVIEW_LENGTH = 60;

	protected override string info
	{
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[CallsUnknownMethods(Count = 40)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "QueueHintLabel")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public Action_QueueLoadScreenHint()
	{
	}
}
