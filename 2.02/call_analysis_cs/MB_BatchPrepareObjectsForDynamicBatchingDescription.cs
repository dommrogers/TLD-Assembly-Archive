using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
