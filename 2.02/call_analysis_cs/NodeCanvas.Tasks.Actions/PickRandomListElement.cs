using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class PickRandomListElement<T> : ActionTask
{
	public BBParameter<List<T>> targetList;

	public BBParameter<T> saveAs;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public PickRandomListElement()
	{
	}
}
