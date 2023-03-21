using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SavePlayerProfile : ActionTask
{
	public bool m_SaveFeats;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SavePlayerProfile()
	{
	}
}
