using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Spin : MonoBehaviour
{
	public Vector3 rotationsPerSecond;

	public bool ignoreTimeScale;

	private Rigidbody mRb;

	private Transform mTrans;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Spin), Member = "ApplyDelta")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Spin), Member = "Update")]
	[CalledBy(Type = typeof(Spin), Member = "FixedUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public void ApplyDelta(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Spin()
	{
	}
}
