using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartAndStopTween : MonoBehaviour
{
	public GameObject target;

	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StartAndStopTween()
	{
	}
}
