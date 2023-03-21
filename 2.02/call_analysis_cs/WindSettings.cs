using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class WindSettings
{
	public string name;

	public Vector2 m_VelocityRange;

	public Vector2 m_GustinessRange;

	public Vector2 m_LateralBlusterRange;

	public Vector2 m_VerticalBlusterRange;

	public Vector2 m_RTPC_Range;

	public Vector3 m_ClothRandomRange;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public WindSettings()
	{
	}
}
