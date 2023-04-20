using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PhoneStopRinging : ActionTask
{
	public string missionObjectIdentifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_PhoneStopRinging()
	{
	}
}
