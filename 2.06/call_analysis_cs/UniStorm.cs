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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	public void Update()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UniStorm()
	{
	}
}
