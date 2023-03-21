using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DestroyGameObjectAfterTime : MonoBehaviour
{
	private float m_Lifetime;

	private float m_TimeRemaining;

	[CallerCount(Count = 0)]
	public void SetLifetime(float lifetime)
	{
	}

	[CallerCount(Count = 0)]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public DestroyGameObjectAfterTime()
	{
	}
}
