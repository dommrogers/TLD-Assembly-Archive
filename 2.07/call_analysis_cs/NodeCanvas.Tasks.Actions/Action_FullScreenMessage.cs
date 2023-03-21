using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_FullScreenMessage : ActionTask
{
	public BBParameter<string> messageLocID;

	public BBParameter<float> displayTime;

	public BBParameter<bool> blackOutScreen;

	public BBParameter<bool> fadeInText;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public Action_FullScreenMessage()
	{
	}
}
