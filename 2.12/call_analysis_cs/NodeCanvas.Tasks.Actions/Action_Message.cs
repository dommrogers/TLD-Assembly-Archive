using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_Message : ActionTask
{
	public BBParameter<string> text;

	public Color textColor;

	public float waitTime;

	public bool scopeToState;

	public CompactStatus finishStatus;

	private PanelReference<Panel_HUD> m_HUD;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NCUtils), Member = "SubstituteVarsInStrings")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowDebugMissionText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowDebugMissionText")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public Action_Message()
	{
	}
}
