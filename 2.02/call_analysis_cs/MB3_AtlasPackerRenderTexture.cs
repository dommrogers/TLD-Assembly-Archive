using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_AtlasPackerRenderTexture : MonoBehaviour
{
	private MB_TextureCombinerRenderTexture fastRenderer;

	private bool _doRenderAtlas;

	public int width;

	public int height;

	public int padding;

	public bool isNormalMap;

	public bool fixOutOfBoundsUVs;

	public bool considerNonTextureProperties;

	public MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

	public Rect[] rects;

	public Texture2D tex1;

	public List<MB_TexSet> textureSets;

	public int indexOfTexSetToRender;

	public ShaderTextureProperty texPropertyName;

	public MB2_LogLevel LOG_LEVEL;

	public Texture2D testTex;

	public Material testMat;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "DoRenderAtlas")]
	[CalledBy(Type = typeof(MB3_TestRenderTextureTestHarness), Member = "TestRender")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerFast._003CCreateAtlases_003Ed__2), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 9)]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	private void OnRenderObject()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
