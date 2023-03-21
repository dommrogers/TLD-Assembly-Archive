using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpecialContainerTag : MonoBehaviour
{
	public bool m_CanStickToGroundOnBreakdown;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SpecialContainerTag()
	{
	}
}
