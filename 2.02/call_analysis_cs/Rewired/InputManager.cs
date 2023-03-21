using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired;

public sealed class InputManager : InputManager_Base
{
	private bool ignoreRecompile;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "SubscribeEvents")]
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
	[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "IsMatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "OnInitialized")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "UnsubscribeEvents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void SubscribeEvents()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "OnDeinitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "SubscribeEvents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void UnsubscribeEvents()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "uOkGINHzUFvBvzDERdNwZKMwKOm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager_Base), Member = ".ctor")]
	public InputManager()
	{
	}
}
