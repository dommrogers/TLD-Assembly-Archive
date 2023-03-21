using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public struct MissionStatusDisplaySettings
{
	public LocalizedString CompletedStatus;

	public Color CompletedColor;

	public string CompletedWwiseEvent;

	public LocalizedString FailedStatus;

	public Color FailedColor;

	public string FailedWwiseEvent;

	public LocalizedString NewStatus;

	public Color NewColor;

	public string NewWwiseEvent;

	public LocalizedString UpdatedStatus;

	public Color UpdatedColor;

	public string UpdatedWwiseEvent;

	[CallerCount(Count = 0)]
	public Color GetColor(MissionStatusType type)
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 1)]
	public string GetLocID(MissionStatusType type)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	public string GetWwiseEvent(MissionStatusType type)
	{
		return null;
	}
}
