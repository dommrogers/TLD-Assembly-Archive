using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Cooking;
using UnityEngine;

namespace TLD.DebugTools.CookingPreview;

public class DebugCookingPreview : MonoBehaviour
{
	[Serializable]
	public class CookingPhaseEffectPairing
	{
		public CookingPotItem.CookingState m_CookingState;

		public GameObject m_EffectRoot;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public CookingPhaseEffectPairing()
		{
		}
	}

	private CookingPotItem.GrubMeshType m_GrubMeshType;

	private MeshFilter m_GrubMeshFilter;

	private MeshRenderer m_GrubMeshRenderer;

	private CookingPhaseEffectPairing[] m_CookingPhaseEffectPairings;

	private GearItem m_CurrentCookingItem;

	private CookingPotItem.CookingState m_CurrentCookingState;

	[CalledBy(Type = typeof(DebugCookingPreview), Member = "RecipeChanged")]
	[CalledBy(Type = typeof(DebugCookingPreview), Member = "CookingStateChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateCookingItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugCookingPreview), Member = "UpdateCookingItem")]
	[CallsUnknownMethods(Count = 2)]
	public void RecipeChanged(RecipeData recipe)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugCookingPreview), Member = "UpdateCookingItem")]
	public void CookingStateChanged(CookingPotItem.CookingState cookingState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DebugCookingPreview()
	{
	}
}
