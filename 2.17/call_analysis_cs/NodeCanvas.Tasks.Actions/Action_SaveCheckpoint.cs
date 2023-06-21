using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SaveCheckpoint : ActionTask
{
	private static float s_NextSaveTime;

	private const float SAVE_DELAY_TIME = 5f;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeSaveCheckpoint")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(GameManager), Member = "HandleCheckpointSaveRequest")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static bool MaybeSave()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SaveCheckpoint()
	{
	}
}
