using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraTrigger : MonoBehaviour
{
	public AuroraBand[] m_AuroraList;

	public bool m_TriggerOn;

	public Color m_CustomColour;

	public float m_TransitionTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraTrigger()
	{
	}
}
