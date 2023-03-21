using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIOrthoCamera : MonoBehaviour
{
	private Camera mCam;

	private Transform mTrans;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UIOrthoCamera()
	{
	}
}
