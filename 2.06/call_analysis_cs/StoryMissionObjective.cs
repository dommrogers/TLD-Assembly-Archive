using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class StoryMissionObjective
{
	public string objectiveID;

	public string descriptionLocID;

	public string descriptionLocUnitsID;

	public string hudDescriptionLocID;

	public bool completed;

	public string timerID;

	public string countCurrentBBName;

	public string countRequiredBBName;

	public MissionObjectiveCountType countType;

	public bool isChildObjective;

	public List<string> childObjectiveIDList;

	public string missionID;

	public bool invisibleInJournal;

	public bool showWhenCompleted;

	public bool showInSummary;

	public bool showSmallKicker;

	public bool ignoreInProgressionCalculation;

	public bool useAsFraction;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Deserialize")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void CopyConstantDataFromResources(StoryMissionObjective other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	private static bool HasStoryMissionObjectiveResourcesAttribute(FieldInfo field)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public string GetDescriptionLocIdForHud()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	public bool TryGetCurrentAndRequired(out float outCurrent, out float outRequired)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref outCurrent) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref outRequired) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StoryMissionObjective()
	{
	}
}
