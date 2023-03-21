using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Spin : MonoBehaviour
{
	public Vector3 rotationsPerSecond;

	public bool ignoreTimeScale;

	private Rigidbody mRb;

	private Transform mTrans;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Spin), Member = "ApplyDelta")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spin), Member = "ApplyDelta")]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Spin), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(Spin), Member = "Update")]
	public void ApplyDelta(float delta)
	{
	}

	[CallerCount(Count = 0)]
	public Spin()
	{
	}
}
