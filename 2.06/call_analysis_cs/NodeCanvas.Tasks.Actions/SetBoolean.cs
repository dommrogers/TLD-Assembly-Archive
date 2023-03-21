using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class SetBoolean : ActionTask
{
	public enum BoolSetModes
	{
		False,
		True,
		Toggle
	}

	public BBParameter<bool> boolVariable;

	public BoolSetModes setTo;

	protected override string info
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SetBoolean()
	{
	}
}
