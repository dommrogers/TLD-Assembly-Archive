using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BreakDownItem : MonoBehaviour
{
	public float m_BreakDownTimeModifier;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BreakDownItem()
	{
	}
}
