using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void OnGUI()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
