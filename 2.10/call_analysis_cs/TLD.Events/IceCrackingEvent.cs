using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Events;

public class IceCrackingEvent : GameEvent
{
	[NonSerialized]
	public Vector3 m_Position;

	[NonSerialized]
	public float m_SecondsBeforeIceCracks;

	[NonSerialized]
	public bool m_FellIntoWater;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	public IceCrackingEvent()
	{
	}
}
