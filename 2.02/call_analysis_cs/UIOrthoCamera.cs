using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIOrthoCamera : MonoBehaviour
{
	private Camera mCam;

	private Transform mTrans;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIOrthoCamera()
	{
	}
}
