using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
