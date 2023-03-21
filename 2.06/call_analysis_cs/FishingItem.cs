using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FishingItem : MonoBehaviour
{
	public FishingItemType m_Type;

	public string m_LineSnappedAudio;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FishingItem()
	{
	}
}
