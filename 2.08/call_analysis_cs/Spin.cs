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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Spin), Member = "ApplyDelta")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Spin), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(Spin), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public void ApplyDelta(float delta)
	{
	}

	[CallerCount(Count = 0)]
	public Spin()
	{
	}
}
