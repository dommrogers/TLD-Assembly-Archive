using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB_TextureCombinerRenderTexture
{
	public MB2_LogLevel LOG_LEVEL;

	private Material mat;

	private RenderTexture _destinationTexture;

	private Camera myCamera;

	private int _padding;

	private bool _isNormalMap;

	private bool _fixOutOfBoundsUVs;

	private bool _doRenderAtlas;

	private Rect[] rs;

	private List<MB_TexSet> textureSets;

	private int indexOfTexSetToRender;

	private ShaderTextureProperty _texPropertyName;

	private MB3_TextureCombinerNonTextureProperties _resultMaterialTextureBlender;

	private Texture2D targTex;

	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(MB3_AtlasPackerRenderTexture), Member = "OnRenderAtlas")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(Camera), Member = "set_aspect")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "_printTexture")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB3_AtlasPackerRenderTexture), Member = "OnRenderObject")]
	[CallsUnknownMethods(Count = 97)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "YisFlipped")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "CopyScaledAndTiledToAtlas")]
	public void OnRenderObject()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	public bool YisFlipped()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "GetColorForTemporaryTexture")]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Graphics), Member = "DrawTexture")]
	private void CopyScaledAndTiledToAtlas(MB_TexSet texSet, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, MB3_TextureCombinerNonTextureProperties resultMatTexBlender, bool yIsFlipped)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void _printTexture(Texture2D t)
	{
	}

	[CallerCount(Count = 0)]
	public MB_TextureCombinerRenderTexture()
	{
	}
}
