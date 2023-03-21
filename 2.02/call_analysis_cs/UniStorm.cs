using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UniStorm : MonoBehaviour
{
	public float flashLength;

	public float lightningStrikeOdds;

	public float minIntensity;

	public float maxIntensity;

	public float minRotationAmount;

	public float maxRotationAmount;

	public float minRotationAmountX;

	public float maxRotationAmountX;

	public float minRotationAmountZ;

	public float maxRotationAmountZ;

	public GameObject lightningBolt1;

	public GameObject lightningBolt2;

	public AudioClip[] lightningSound;

	private int lastTime;

	private float random;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public UniStorm()
	{
	}
}
