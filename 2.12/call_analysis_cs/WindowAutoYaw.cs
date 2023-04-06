using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindowAutoYaw : MonoBehaviour
{
	public int updateOrder;

	public Camera uiCamera;

	public float yawAmount;

	private Transform mTrans;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public WindowAutoYaw()
	{
	}
}
