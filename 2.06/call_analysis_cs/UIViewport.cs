using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera;

	public Transform topLeft;

	public Transform bottomRight;

	public float fullSize;

	private Camera mCam;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public UIViewport()
	{
	}
}
