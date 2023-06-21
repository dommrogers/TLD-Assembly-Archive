using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TransformAtNight : MonoBehaviour
{
	private bool m_ReverseToD;

	private bool m_AdjustPosition;

	private Vector3 m_Position;

	private Vector3 m_OriginalPosition;

	private bool m_AdjustRotation;

	private Vector3 m_Rotation;

	private Vector3 m_OriginalRotation;

	private bool m_AdjustScale;

	private Vector3 m_Scale;

	private Vector3 m_OriginalScale;

	private float m_NightPercentage;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetNightPercentage")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public TransformAtNight()
	{
	}
}
