using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_DisableCharacterController : ActionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_DisableCharacterController()
	{
	}
}
