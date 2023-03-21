using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartAndStopTween : MonoBehaviour
{
	public GameObject target;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(iTweenEvent), Member = "StartEvent")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
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
