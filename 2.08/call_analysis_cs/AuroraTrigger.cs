using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraTrigger : MonoBehaviour
{
	public AuroraBand[] m_AuroraList;

	public bool m_TriggerOn;

	public Color m_CustomColour;

	public float m_TransitionTime;

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public AuroraTrigger()
	{
	}
}
