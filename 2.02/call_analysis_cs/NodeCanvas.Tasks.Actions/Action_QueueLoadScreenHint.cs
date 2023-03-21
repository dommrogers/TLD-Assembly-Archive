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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 40)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Loading), Member = "QueueHintLabel")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public Action_QueueLoadScreenHint()
	{
	}
}
