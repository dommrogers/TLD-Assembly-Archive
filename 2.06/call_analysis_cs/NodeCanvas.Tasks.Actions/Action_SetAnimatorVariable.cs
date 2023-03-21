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

	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "DoWork")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private Animator GetAnimator()
	{
		return null;
	}

	[Calls(Type = typeof(int), Member = "Parse")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action_SetAnimatorVariable), Member = "GetAnimator")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetAnimatorVariable()
	{
	}
}
