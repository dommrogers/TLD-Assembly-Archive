using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public Transform m_MinuteHand;

	public Transform m_HourHand;

	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
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
