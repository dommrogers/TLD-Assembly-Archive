using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
