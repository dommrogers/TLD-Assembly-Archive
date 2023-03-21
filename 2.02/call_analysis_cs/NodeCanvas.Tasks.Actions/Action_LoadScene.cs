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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action_LoadScene()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
