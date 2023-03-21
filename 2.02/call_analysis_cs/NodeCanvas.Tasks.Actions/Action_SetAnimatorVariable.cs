using System;
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

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetAnimatorVariable), Member = "DoWork")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "DoWork")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private Animator GetAnimator()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(Action_SetAnimatorVariable), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Action_SetAnimatorVariable), Member = "GetAnimator")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetAnimatorVariable()
	{
	}
}
