using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CarryingCapacityBuff : MonoBehaviour
{
	[Serializable]
	public class BuffValues
	{
		public float m_MaxCarryCapacityKGBuff;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void Add(BuffValues other)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Zero()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public BuffValues()
		{
		}
	}

	public BuffValues m_CarryingCapacityBuffValues;

	public bool m_IsWorn;

	public string m_SpecialInventoryOpenSound;

	public string m_SpecialInventoryCloseSound;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CarryingCapacityBuff()
	{
	}
}
