using System;
using UnityEngine;

namespace TLD.Scenes;

[Serializable]
public struct WorldToMap
{
	public Vector3 m_CenterOfScene;

	public Vector3 m_RadiusOfScene;

	public float m_Angle;
}
