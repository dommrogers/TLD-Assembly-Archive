using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class SetObjectActive : ActionTask<Transform>
{
	public enum SetActiveMode
	{
		Deactivate,
		Activate,
		Toggle
	}

	public SetActiveMode setTo;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SetObjectActive()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
