using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class SetListElement<T> : ActionTask
{
	public BBParameter<List<T>> targetList;

	public BBParameter<int> index;

	public BBParameter<T> newValue;

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetListElement()
	{
	}
}
