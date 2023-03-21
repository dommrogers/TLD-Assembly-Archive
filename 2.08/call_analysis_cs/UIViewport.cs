using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera;

	public Transform topLeft;

	public Transform bottomRight;

	public float fullSize;

	private Camera mCam;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[CallsUnknownMethods(Count = 12)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public UIViewport()
	{
	}
}
