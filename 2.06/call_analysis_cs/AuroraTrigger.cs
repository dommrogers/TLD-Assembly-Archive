using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraTrigger : MonoBehaviour
{
	public AuroraBand[] m_AuroraList;

	public bool m_TriggerOn;

	public Color m_CustomColour;

	public float m_TransitionTime;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public AuroraTrigger()
	{
	}
}
