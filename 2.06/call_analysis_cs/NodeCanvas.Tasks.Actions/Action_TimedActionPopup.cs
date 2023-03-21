using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_TimedActionPopup : ActionTask
{
	public InputManager.InputAction Action;

	public float DisplayTime;

	public float HoldTime;

	public string PromptKey;

	private PanelReference<Panel_HUD> m_HUD;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 22)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimedActionPopup), Member = "Setup")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_TimedActionPopup()
	{
	}
}
