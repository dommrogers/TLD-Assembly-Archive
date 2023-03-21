using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_BuildCustomWeatherSetId : ActionTask
{
	public string weatherSetFolderName;

	public string customSetVarName;

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_BuildCustomWeatherSetId()
	{
	}
}
