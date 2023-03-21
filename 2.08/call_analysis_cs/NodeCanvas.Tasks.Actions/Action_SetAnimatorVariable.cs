using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetAnimatorVariable : ActionTask
{
	public bool onThisObject;

	public string missionObjectIdentifierString;

	public string animatorControllerName;

	public BBParameter<string> bbParameter;

	public string defaultParameter;

	public AnimatorControllerParameterType parameterType;

	public string value;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetAnimatorVariable), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "DoWork")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private Animator GetAnimator()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Action_SetAnimatorVariable), Member = "GetAnimator")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "OnExecute")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetAnimatorVariable()
	{
	}
}
