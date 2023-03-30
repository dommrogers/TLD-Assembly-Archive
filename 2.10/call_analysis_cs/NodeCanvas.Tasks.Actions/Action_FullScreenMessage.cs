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
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 4)]
	public Action_FullScreenMessage()
	{
	}
}
