using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SelectNextPhoneDT : ActionTask
{
	public BBParameter<DTContainer> dialogueTreeContainer;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SelectNextPhoneDT()
	{
	}
}
