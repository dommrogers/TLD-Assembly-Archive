using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired;

public sealed class InputManager : InputManager_Base
{
	private bool ignoreRecompile;

	[Calls(Type = typeof(InputManager), Member = "SubscribeEvents")]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected override void DetectPlatform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected override void CheckRecompile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override IExternalTools GetExternalTools()
	{
		return null;
	}

	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CalledBy(Type = typeof(InputManager), Member = "OnInitialized")]
	[CallsUnknownMethods(Count = 7)]
	private void SubscribeEvents()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CalledBy(Type = typeof(InputManager), Member = "OnDeinitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "SubscribeEvents")]
	[CallsUnknownMethods(Count = 7)]
	private void UnsubscribeEvents()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "uOkGINHzUFvBvzDERdNwZKMwKOm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager_Base), Member = ".ctor")]
	public InputManager()
	{
	}
}
