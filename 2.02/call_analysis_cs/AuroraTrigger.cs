using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraTrigger : MonoBehaviour
{
	public AuroraBand[] m_AuroraList;

	public bool m_TriggerOn;

	public Color m_CustomColour;

	public float m_TransitionTime;

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraTrigger()
	{
	}
}
