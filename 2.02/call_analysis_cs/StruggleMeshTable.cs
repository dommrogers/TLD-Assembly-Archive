using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StruggleMeshTable : MonoBehaviour
{
	public MeshFilter m_BareHands;

	public MeshFilter m_Knife;

	public MeshFilter m_Hatchet;

	public MeshFilter m_Prybar;

	public MeshFilter m_ImprovisedKnife;

	public MeshFilter m_ImprovisedHatchet;

	public MeshFilter m_Hammer;

	public MeshFilter m_Revolver;

	private Dictionary<StruggleBonus.StruggleWeaponType, MeshFilter> m_SturggleMeshTable;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "GetRevolverMuzzleFlashGO")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public MeshFilter GetMesh(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public StruggleMeshTable()
	{
	}
}
