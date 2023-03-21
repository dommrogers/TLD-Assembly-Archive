using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TextureInjector : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Material> _003C_003E9__17_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		internal bool _003CInitialize_003Eb__17_0(Material item)
		{
			return default(bool);
		}
	}

	public Color m_ColourOverride;

	public bool m_ForceColour;

	public Texture2D m_AmbientOcclusionMap;

	public float m_AmbientStrength;

	public Texture2D m_NoiseOverlayMap;

	public float m_NoiseStrength;

	public Vector2 m_NoiseTiling;

	public bool m_ForceNoiseTiling;

	public Texture2D m_EmissiveMap;

	public float m_EmissiveStrength;

	public List<Material> m_IgnoreMaterials;

	public bool m_AutoLoad;

	private List<Material> m_LocalMaterials;

	private bool m_IsReady;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallerCount(Count = 0)]
	public void LoadTextures()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	public void UnloadTextures()
	{
	}

	[Calls(Type = typeof(TextureInjector), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(TextureInjector), Member = "Contains")]
	[CalledBy(Type = typeof(TextureInjector), Member = "UnloadTextures")]
	[CalledBy(Type = typeof(TextureInjector), Member = "LoadTextures")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TextureInjector), Member = "Initialize")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	private int Contains(List<Material> localList, string matName)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public TextureInjector()
	{
	}
}
