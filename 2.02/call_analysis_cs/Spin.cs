using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Spin : MonoBehaviour
{
	public Vector3 rotationsPerSecond;

	public bool ignoreTimeScale;

	private Rigidbody mRb;

	private Transform mTrans;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Spin), Member = "ApplyDelta")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Spin), Member = "ApplyDelta")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate()
	{
	}

	[CalledBy(Type = typeof(Spin), Member = "Update")]
	[CalledBy(Type = typeof(Spin), Member = "FixedUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void ApplyDelta(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Spin()
	{
	}
}
