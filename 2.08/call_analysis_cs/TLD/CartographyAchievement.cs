using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD;

[Serializable]
public class CartographyAchievement
{
	public string m_LocId;

	public string m_DisplayText;

	public string m_Guid;

	public string m_SceneName;

	public Vector3 m_WorldLocation;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CartographyAchievement()
	{
	}
}
