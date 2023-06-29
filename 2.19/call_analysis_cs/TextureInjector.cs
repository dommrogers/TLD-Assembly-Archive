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
		internal bool _003CInitialize_003Eb__17_0(Material item)
		{
			return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureInjector), Member = "Initialize")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[CallsUnknownMethods(Count = 10)]
	public void LoadTextures()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureInjector), Member = "Initialize")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[CallsUnknownMethods(Count = 10)]
	public void UnloadTextures()
	{
	}

	[CalledBy(Type = typeof(TextureInjector), Member = "LoadTextures")]
	[CalledBy(Type = typeof(TextureInjector), Member = "UnloadTextures")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[Calls(Type = typeof(TextureInjector), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 18)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(TextureInjector), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int Contains(List<Material> localList, string matName)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public TextureInjector()
	{
	}
}
