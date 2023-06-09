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
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "GetRevolverMuzzleFlashGO")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public MeshFilter GetMesh(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StruggleMeshTable()
	{
	}
}
