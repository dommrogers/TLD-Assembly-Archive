using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireMass
{
	public Vector3 pos;

	public Vector3 last;

	public Vector3 force;

	public Vector3 vel;

	public Vector3 posc;

	public Vector3 velc;

	public Vector3 forcec;

	public float mass;

	public float oneovermass;

	public bool collide;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "Init")]
	public MegaWireMass(float m, Vector3 p)
	{
	}
}
