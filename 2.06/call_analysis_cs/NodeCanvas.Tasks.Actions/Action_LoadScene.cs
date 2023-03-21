using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Actions;

public class Action_LoadScene : ActionTask<GraphOwner>
{
	public enum ActionCondition
	{
		AlwaysRun,
		JustForDebugMissionJump,
		JustForSaveRestore
	}

	public string sceneName;

	public bool allowReloadOfCurrentScene;

	public bool waitDeserializeCompleted;

	public ActionCondition actionCondition;

	public string audioEventOnStart;

	public bool skipFadeInOnLoad;

	public bool keepAudioPlaying;

	public bool holdCameraFadeAfterLoad;

	public bool forceMissionJumpState;

	public static bool m_ForceSceneReload;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public Action_LoadScene()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
