using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
	public GunType m_AmmoForGunType;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AmmoItem()
	{
	}
}
