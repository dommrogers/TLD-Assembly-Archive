using System;
using System.Collections.Generic;
using System.Reflection;
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

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void CopyConstantDataFromResources(StoryMissionObjective other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasStoryMissionObjectiveResourcesAttribute(FieldInfo field)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public string GetDescriptionLocIdForHud()
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetNumObjectivesForMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "GetNumCompletedObjectivesForMission")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool TryGetCurrentAndRequired(out float outCurrent, out float outRequired)
	{
		outCurrent = default(float);
		outRequired = default(float);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StoryMissionObjective()
	{
	}
}
