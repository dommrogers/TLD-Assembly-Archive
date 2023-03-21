using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpecialContainerTag : MonoBehaviour
{
	public bool m_CanStickToGroundOnBreakdown;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SpecialContainerTag()
	{
	}
}
