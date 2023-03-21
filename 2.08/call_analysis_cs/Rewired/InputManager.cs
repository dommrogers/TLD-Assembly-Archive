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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override void DetectPlatform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void CheckRecompile()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(InputManager), Member = "OnInitialized")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallerCount(Count = 3)]
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
