using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindowAutoYaw : MonoBehaviour
{
	public int updateOrder;

	public Camera uiCamera;

	public float yawAmount;

	private Transform mTrans;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public WindowAutoYaw()
	{
	}
}
