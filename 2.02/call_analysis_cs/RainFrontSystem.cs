using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class RainFrontSystem : MonoBehaviour
{
	public float speed;

	public float xMin;

	public float xMax;

	public float zMin;

	public float zMax;

	private Vector3 point;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public virtual void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "MoveTowards")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RainFrontSystem()
	{
	}
}
