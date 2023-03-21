using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleKiller : MonoBehaviour
{
	public bool m_KillsFallingSnow;

	public bool m_KillsBlowingSnow;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParticleKiller()
	{
	}
}
