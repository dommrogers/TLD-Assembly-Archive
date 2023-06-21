using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

public class BaitItem : MonoBehaviour
{
	private float m_MinFishWeightModifier;

	public float MinFishWeightModifier
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BaitItem()
	{
	}
}
