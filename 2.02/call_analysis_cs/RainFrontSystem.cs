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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Vector3), Member = "MoveTowards")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RainFrontSystem()
	{
	}
}
