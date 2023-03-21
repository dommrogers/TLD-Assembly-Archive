using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AmmoCasingItem : MonoBehaviour
{
	public GunType m_AmmoForGunType;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AmmoCasingItem()
	{
	}
}
