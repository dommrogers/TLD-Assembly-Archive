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

	[CalledBy(Type = typeof(MB3_TestRenderTextureTestHarness), Member = "TestRender")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBakerFast.<CreateAtlases>d__2", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "DoRenderAtlas")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB_TextureCombinerRenderTexture), Member = "OnRenderObject")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenderObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
