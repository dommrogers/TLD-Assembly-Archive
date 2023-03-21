using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SaveCheckpoint : ActionTask
{
	private static float s_NextSaveTime;

	private const float SAVE_DELAY_TIME = 5f;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "HandleCheckpointSaveRequest")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeSaveCheckpoint")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 7)]
	public static bool MaybeSave()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SaveCheckpoint()
	{
	}
}
