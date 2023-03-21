using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SuffocatingSettings : MonoBehaviour
{
	public float m_SuffocatingDelayTimerSeconds;

	public float m_SuffocatingTimerSeconds;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SuffocatingSettings()
	{
	}
}
