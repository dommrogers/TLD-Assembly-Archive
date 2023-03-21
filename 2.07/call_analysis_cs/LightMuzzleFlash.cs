using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightMuzzleFlash : MonoBehaviour
{
	public float duration;

	public float intensity;

	public float radius;

	private float durTimer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_range")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Shoot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LightMuzzleFlash()
	{
	}
}
