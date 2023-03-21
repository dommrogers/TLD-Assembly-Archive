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
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetBackgroundData")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetTextData")]
	[Calls(Type = typeof(Panel_Loading), Member = "ForceMinHoldTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 11)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetLoadScreenBackgroundOrText()
	{
	}
}
