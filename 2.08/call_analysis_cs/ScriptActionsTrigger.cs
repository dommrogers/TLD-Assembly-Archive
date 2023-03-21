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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ScriptActionsTrigger()
	{
	}
}
