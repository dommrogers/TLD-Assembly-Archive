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
		[CallsUnknownMethods(Count = 40)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_Loading), Member = "QueueHintLabel")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Action_QueueLoadScreenHint()
	{
	}
}
