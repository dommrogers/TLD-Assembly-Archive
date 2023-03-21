using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WanderRegion : MonoBehaviour
{
	public float m_Radius;

	public float m_WanderMinHours;

	public float m_WanderMaxHours;

	public bool m_Used;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WanderRegion()
	{
	}
}
