using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadLevelOnClick : MonoBehaviour
{
	public string levelName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LoadLevelOnClick()
	{
	}
}
