using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class FPSItem : ScriptableObject
{
	public AssetReferenceFPSWeapon m_FPSWeaponPrefab;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FPSItem()
	{
	}
}
