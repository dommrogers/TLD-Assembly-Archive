using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ForceCustomLoadScreen : ActionTask
{
	private const int LOC_PREVIEW_LENGTH = 60;

	public BBParameter<string> locID;

	public float minHoldTime;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Utils), Member = "LocKeyPreview")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Action_ForceCustomLoadScreen()
	{
	}
}
