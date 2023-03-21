using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetStatusBarLock : ActionTask
{
	public BBParameter<bool> setStatusBarLock;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action_SetStatusBarLock()
	{
	}
}
