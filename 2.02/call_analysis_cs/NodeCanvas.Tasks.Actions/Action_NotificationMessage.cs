using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_NotificationMessage : ActionTask
{
	public BBParameter<string> titleLocID;

	public BBParameter<string> messageLocID;

	public BBParameter<string> iconName;

	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public Action_NotificationMessage()
	{
	}
}
