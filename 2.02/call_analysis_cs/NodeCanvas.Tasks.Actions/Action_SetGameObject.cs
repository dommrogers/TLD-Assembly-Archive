using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetGameObject : ActionTask
{
	public enum TargetType
	{
		Player,
		PlayerCamera,
		MissionObjectIdentifier
	}

	public BBParameter<GameObject> target;

	public BBParameter<TargetType> targetType;

	public BBParameter<string> missionObjectIdentifierString;

	private int retryCounter;

	private int maxRetries;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Action_SetGameObject), Member = "SetTarget")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(Action_SetGameObject), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 11)]
	protected bool SetTarget()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Action_SetGameObject()
	{
	}
}
