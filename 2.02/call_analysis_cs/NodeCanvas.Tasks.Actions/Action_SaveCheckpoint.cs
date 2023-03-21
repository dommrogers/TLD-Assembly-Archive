using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SaveCheckpoint : ActionTask
{
	private static float s_NextSaveTime;

	private const float SAVE_DELAY_TIME = 5f;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "OnUpdate")]
	[CalledBy(Type = typeof(State_SaveCheckpoint), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "HandleCheckpointSaveRequest")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeSaveCheckpoint")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public static bool MaybeSave()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SaveCheckpoint()
	{
	}
}
