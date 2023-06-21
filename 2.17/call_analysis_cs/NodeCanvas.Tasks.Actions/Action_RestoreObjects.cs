using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RestoreObjects : ActionTask
{
	public List<string> objectList;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NCUtils), Member = "GetHostState")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action_RestoreObjects()
	{
	}
}
