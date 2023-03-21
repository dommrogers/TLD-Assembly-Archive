using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceFishingHoleClearItem : MonoBehaviour
{
	public float m_HPDecreaseToClear;

	public float m_NumGameMinutesToClear;

	public string m_BreakIceAudio;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public IceFishingHoleClearItem()
	{
	}
}
