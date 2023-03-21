using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
