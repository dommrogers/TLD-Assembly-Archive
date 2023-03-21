using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AmmoCasingItem : MonoBehaviour
{
	public GunType m_AmmoForGunType;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AmmoCasingItem()
	{
	}
}
