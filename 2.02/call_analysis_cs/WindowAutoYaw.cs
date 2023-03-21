using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindowAutoYaw : MonoBehaviour
{
	public int updateOrder;

	public Camera uiCamera;

	public float yawAmount;

	private Transform mTrans;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public WindowAutoYaw()
	{
	}
}
