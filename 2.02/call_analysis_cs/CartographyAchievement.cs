using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class CartographyAchievement
{
	public string m_LocId;

	public string m_DisplayText;

	public string m_Guid;

	public Vector3 m_WorldLocation;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CartographyAchievement()
	{
	}
}
