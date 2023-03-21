using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OpenCloseTrigger : MonoBehaviour
{
	private OpenClose m_OpenClose;

	private bool m_IsImmediate;

	private bool m_OpenOnTriggerEnter;

	private bool m_CloseOnTriggerExit;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public OpenCloseTrigger()
	{
	}
}
