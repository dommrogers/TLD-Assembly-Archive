using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIOrthoCamera : MonoBehaviour
{
	private Camera mCam;

	private Transform mTrans;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIOrthoCamera()
	{
	}
}
