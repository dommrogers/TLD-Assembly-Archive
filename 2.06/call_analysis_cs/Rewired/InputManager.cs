using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired;

public sealed class InputManager : InputManager_Base
{
	private bool ignoreRecompile;

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnInitialized()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	protected override void OnDeinitialized()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void DetectPlatform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void CheckRecompile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected override IExternalTools GetExternalTools()
	{
		return null;
	}

	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	[CallerCount(Count = 0)]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsUnknownMethods(Count = 7)]
	private void SubscribeEvents()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CalledBy(Type = typeof(InputManager), Member = "OnInitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "OnDeinitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "SubscribeEvents")]
	private void UnsubscribeEvents()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "bTpyOpRGeDPPHqqwooGngOxGYFE")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager_Base), Member = ".ctor")]
	public InputManager()
	{
	}
}
