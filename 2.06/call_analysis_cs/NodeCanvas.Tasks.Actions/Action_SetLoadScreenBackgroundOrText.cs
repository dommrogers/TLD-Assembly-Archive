using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetLoadScreenBackgroundOrText : ActionTask
{
	public BBParameter<LoadingScreenData> data;

	public bool isFallbackNode;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetBackgroundData")]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SetLoadScreenBackgroundOrText()
	{
	}
}
