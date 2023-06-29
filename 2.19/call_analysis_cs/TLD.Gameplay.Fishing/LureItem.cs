using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

public class LureItem : MonoBehaviour
{
	private float m_CatchModifier;

	private float m_RareFishModifier;

	public float CatchModifier
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float RareFishModifier
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
	public LureItem()
	{
	}
}
