using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
