using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
	public bool m_FaceCamera;

	public bool m_YAxisOnly;

	public Vector3 m_OrientationOffset;

	private Vector3 m_TargetPosition;

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FaceCamera()
	{
	}
}
