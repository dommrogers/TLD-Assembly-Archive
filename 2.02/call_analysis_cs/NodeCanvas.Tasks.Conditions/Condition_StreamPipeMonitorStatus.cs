using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_StreamPipeMonitorStatus : ConditionTask
{
	public BBParameter<string> checkForMissionObjectId;

	public float flowValueThreshold;

	public string sceneValidation;

	private SteamPipe m_SteamPipe;

	private bool m_LogValidationError;

	[Calls(Type = typeof(Condition_StreamPipeMonitorStatus), Member = "InitializeSteamPipe")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void LogValidationError(string message)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Condition_StreamPipeMonitorStatus), Member = "OnInit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void InitializeSteamPipe()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public Condition_StreamPipeMonitorStatus()
	{
	}
}
