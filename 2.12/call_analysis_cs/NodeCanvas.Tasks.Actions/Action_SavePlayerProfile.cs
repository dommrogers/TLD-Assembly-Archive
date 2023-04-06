using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SavePlayerProfile : ActionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SavePlayerProfile()
	{
	}
}
