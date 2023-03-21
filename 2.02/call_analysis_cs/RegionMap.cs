using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class RegionMap
{
	public string m_RegionName;

	public GameObject m_RegionMapObject;

	public Vector3 m_CenterOfScene;

	public Vector3 m_RadiusOfScene;

	public float m_Angle;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RegionMap()
	{
	}
}
