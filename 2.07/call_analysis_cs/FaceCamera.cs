using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
	public bool m_FaceCamera;

	public bool m_YAxisOnly;

	public Vector3 m_OrientationOffset;

	private Vector3 m_TargetPosition;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FaceCamera()
	{
	}
}
