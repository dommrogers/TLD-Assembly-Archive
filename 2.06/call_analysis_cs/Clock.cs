using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public Transform m_MinuteHand;

	public Transform m_HourHand;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Clock()
	{
	}
}
