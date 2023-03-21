using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadLevelOnClick : MonoBehaviour
{
	public string levelName;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LoadLevelOnClick()
	{
	}
}
