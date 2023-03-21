using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteriorLightingGroup : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GameObject> _003C_003E9__11_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		internal bool _003CStart_003Eb__11_0(GameObject item)
		{
			return default(bool);
		}
	}

	public List<GameObject> m_Objects;

	public ScaledCurve m_GlowOverride;

	private readonly List<Light> m_Lights;

	private readonly List<MeshRenderer> m_GlowObjects;

	private readonly List<ParticleSystem> m_FX;

	private readonly List<LightShaftGimble> m_LightShafts;

	private readonly List<float> m_OrgLitValue;

	private readonly List<Color> m_OrgLitColour;

	private readonly List<Color> m_OrgFxColour;

	private readonly List<Material> m_GlowObjectMaterialsToUpdate;

	private readonly List<Color> m_GlowObjectMaterialsOriginalColor;

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(InteriorLightingGroup), Member = "DetermineObject")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(ParticleSystem.MinMaxGradient), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 14)]
	public void ScrubUpdate(float intensityMultiplier, Color newColor, float timeOfDay)
	{
	}

	[CalledBy(Type = typeof(InteriorLightingGroup), Member = "Start")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DetermineObject(List<GameObject> goList)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 25)]
	public List<Light> GetLights()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public List<LightShaftGimble> GetLightShafts()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
	public List<ParticleSystem> GetParticles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[CallsUnknownMethods(Count = 5)]
	public InteriorLightingGroup()
	{
	}
}
