using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using UnityEngine;
using UnityEngine.Rendering;

public class IceCrackVisualization : MonoBehaviour
{
	private class DecalData
	{
		public StaticDecal m_Decal;

		public float m_CrackAmount;

		public float m_LastUpdateTime;

		public float m_Lifetime;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public DecalData()
		{
		}

		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public IceCrackVisualization _003C_003E4__this;

		public DecalData decalData;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IceCrackVisualization), Member = "OnProcessCommandBuffer")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003COnIceCracked_003Eb__0(CommandBuffer commandBuffer)
		{
		}
	}

	private IceCrackingEvent m_IceCrackingEvent;

	private IceCrackVisualizationData m_Data;

	private DecalData[] m_Decals;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(IceCrackVisualizationData), Member = "BlendRecrack")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveStaticDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddStaticDecal")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void OnIceCracked()
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<OnIceCracked>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnProcessCommandBuffer(DecalData decalData, CommandBuffer commandBuffer)
	{
	}

	[CallerCount(Count = 0)]
	public IceCrackVisualization()
	{
	}
}
