using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
