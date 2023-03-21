using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartAndStopTween : MonoBehaviour
{
	public GameObject target;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public StartAndStopTween()
	{
	}
}
