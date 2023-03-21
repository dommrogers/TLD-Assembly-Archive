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
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetGameObject), Member = "SetTarget")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_SetGameObject), Member = "OnUpdate")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	protected bool SetTarget()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Action_SetGameObject()
	{
	}
}
