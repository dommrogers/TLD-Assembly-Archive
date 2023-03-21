using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_FadeOutScriptLightOn : ActionTask
{
	public BBParameter<string> scriptLightMissionId;

	public BBParameter<float> fadeoutDurationSeconds;

	public BBParameter<bool> waitForComplete;

	private ScriptLight m_ScriptLight;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_FadeOutScriptLightOn), Member = "StartScriptLightFadeOut")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_FadeOutScriptLightOn), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	private void StartScriptLightFadeOut()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_FadeOutScriptLightOn()
	{
	}
}
