using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartAndStopTween : MonoBehaviour
{
	public GameObject target;

	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(iTweenEvent), Member = "StartEvent")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(iTweenEvent), Member = "StartEvent")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StartAndStopTween()
	{
	}
}
