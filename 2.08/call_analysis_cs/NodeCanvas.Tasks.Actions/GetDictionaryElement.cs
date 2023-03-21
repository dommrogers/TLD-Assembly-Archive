using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class GetDictionaryElement<T> : ActionTask
{
	public BBParameter<Dictionary<string, T>> dictionary;

	public BBParameter<string> key;

	public BBParameter<T> saveAs;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GetDictionaryElement()
	{
	}
}
