using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScriptActionsTrigger : MonoBehaviour
{
	public bool m_SupressNonCriticalSpeech;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ScriptActionsTrigger()
	{
	}
}
