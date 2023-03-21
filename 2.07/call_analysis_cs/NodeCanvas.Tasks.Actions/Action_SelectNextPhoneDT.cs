using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SelectNextPhoneDT : ActionTask
{
	public BBParameter<DTContainer> dialogueTreeContainer;

	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SelectNextPhoneDT()
	{
	}
}
