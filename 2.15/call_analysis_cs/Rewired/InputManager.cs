using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Data;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired;

public sealed class InputManager : InputManager_Base
{
	private bool ignoreRecompile;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 1)]
	protected override IExternalTools GetExternalTools()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsUnknownMethods(Count = 2)]
	private void SubscribeEvents()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "OnInitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "OnDeinitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "SubscribeEvents")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallsUnknownMethods(Count = 2)]
	private void UnsubscribeEvents()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "bTpyOpRGeDPPHqqwooGngOxGYFE")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public InputManager()
	{
	}
}
