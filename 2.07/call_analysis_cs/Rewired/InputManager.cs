using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Data;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired;

public sealed class InputManager : InputManager_Base
{
	private bool ignoreRecompile;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	protected override void OnInitialized()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	protected override void OnDeinitialized()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void DetectPlatform()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsUnknownMethods(Count = 2)]
	private void SubscribeEvents()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "SubscribeEvents")]
	[CalledBy(Type = typeof(InputManager), Member = "OnDeinitialized")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CalledBy(Type = typeof(InputManager), Member = "OnInitialized")]
	private void UnsubscribeEvents()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "bTpyOpRGeDPPHqqwooGngOxGYFE")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UserData), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputManager()
	{
	}
}
