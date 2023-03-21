using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceFishingHoleClearItem : MonoBehaviour
{
	public float m_HPDecreaseToClear;

	public float m_NumGameMinutesToClear;

	public string m_BreakIceAudio;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public IceFishingHoleClearItem()
	{
	}
}
