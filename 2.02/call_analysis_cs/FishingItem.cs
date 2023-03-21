using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FishingItem : MonoBehaviour
{
	public FishingItemType m_Type;

	public string m_LineSnappedAudio;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FishingItem()
	{
	}
}
