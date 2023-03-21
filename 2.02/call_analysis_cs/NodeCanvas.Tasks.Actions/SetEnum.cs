using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Tasks.Actions;

public class SetEnum : ActionTask
{
	public BBObjectParameter valueA;

	public BBObjectParameter valueB;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public SetEnum()
	{
	}
}
