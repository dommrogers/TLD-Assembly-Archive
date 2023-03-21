using System;
using System.Collections.Generic;
using System.Linq;
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
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	public void LoadTextures()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	public void UnloadTextures()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(TextureInjector), Member = "UnloadTextures")]
	[CalledBy(Type = typeof(TextureInjector), Member = "LoadTextures")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(TextureInjector), Member = "Contains")]
	[Calls(Type = typeof(TextureInjector), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 2)]
	private void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TextureInjector), Member = "Initialize")]
	[CalledBy(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private int Contains(List<Material> localList, string matName)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public TextureInjector()
	{
	}
}
