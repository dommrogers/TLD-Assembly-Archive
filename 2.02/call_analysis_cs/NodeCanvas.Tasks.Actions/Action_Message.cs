using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_Message : ActionTask
{
	public BBParameter<string> text;

	public Color textColor;

	public float waitTime;

	public bool scopeToState;

	public CompactStatus finishStatus;

	protected override string info
	{
		[CallsUnknownMethods(Count = 17)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NCUtils), Member = "SubstituteVarsInStrings")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowDebugMissionText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowDebugMissionText")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public Action_Message()
	{
	}
}
