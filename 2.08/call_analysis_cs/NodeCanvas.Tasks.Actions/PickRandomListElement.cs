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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 8)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PickRandomListElement()
	{
	}
}
