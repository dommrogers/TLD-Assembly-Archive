using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_NotificationMessage : ActionTask
{
	public BBParameter<string> titleLocID;

	public BBParameter<string> messageLocID;

	public BBParameter<string> iconName;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	public Action_NotificationMessage()
	{
	}
}
