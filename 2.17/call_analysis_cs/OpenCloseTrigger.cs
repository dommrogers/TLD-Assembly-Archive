using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenCloseTrigger : MonoBehaviour
{
	private OpenClose m_OpenClose;

	private bool m_IsImmediate;

	private bool m_OpenOnTriggerEnter;

	private bool m_CloseOnTriggerExit;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public OpenCloseTrigger()
	{
	}
}
