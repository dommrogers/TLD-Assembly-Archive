using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_CommandBlock : ActionTask
{
	public BBParameter<string> commandString;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "SplitInternal")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public Action_CommandBlock()
	{
	}
}
