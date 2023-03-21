using System.Globalization;
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

	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "DoWork")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private Animator GetAnimator()
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action_SetAnimatorVariable), Member = "GetAnimator")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(bool), Member = "Parse")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "ParseInt32")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetAnimatorVariable()
	{
	}
}
