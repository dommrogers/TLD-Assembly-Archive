using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadLevelOnClick : MonoBehaviour
{
	public string levelName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LoadLevelOnClick()
	{
	}
}
