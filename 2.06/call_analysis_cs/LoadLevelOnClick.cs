using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadLevelOnClick : MonoBehaviour
{
	public string levelName;

	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LoadLevelOnClick()
	{
	}
}
