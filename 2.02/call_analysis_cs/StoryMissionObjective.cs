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

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Deserialize")]
	public void CopyConstantDataFromResources(StoryMissionObjective other)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool HasStoryMissionObjectiveResourcesAttribute(FieldInfo field)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public string GetDescriptionLocIdForHud()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[CallsUnknownMethods(Count = 4)]
	public bool TryGetCurrentAndRequired(out float outCurrent, out float outRequired)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref outCurrent) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref outRequired) = null;
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public StoryMissionObjective()
	{
	}
}
