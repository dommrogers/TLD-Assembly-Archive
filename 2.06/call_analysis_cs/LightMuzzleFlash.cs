using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightMuzzleFlash : MonoBehaviour
{
	public float duration;

	public float intensity;

	public float radius;

	private float durTimer;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "set_range")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 5)]
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
	[CallerCount(Count = 12)]
	public LightMuzzleFlash()
	{
	}
}
