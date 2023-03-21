using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Actions;

public class LoadScene : ActionTask
{
	public BBParameter<string> sceneName;

	public BBParameter<LoadSceneMode> mode;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LoadScene()
	{
	}
}
