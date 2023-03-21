using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderStandardMetallic : TextureBlender
{
	private enum Prop
	{
		doColor,
		doMetallic,
		doEmission,
		doBump,
		doNone
	}

	private static Color NeutralNormalMap;

	private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

	private Color m_tintColor;

	private float m_glossiness;

	private float m_glossMapScale;

	private float m_metallic;

	private bool m_hasMetallicGlossMap;

	private float m_bumpScale;

	private bool m_shaderDoesEmission;

	private Color m_emissionColor;

	private Prop propertyToDo;

	private Color m_generatingTintedAtlasColor;

	private float m_generatingTintedAtlasMetallic;

	private float m_generatingTintedAtlasGlossiness;

	private float m_generatingTintedAtlasGlossMapScale;

	private float m_generatingTintedAtlasBumpScale;

	private Color m_generatingTintedAtlasEmission;

	private Color m_notGeneratingAtlasDefaultColor;

	private float m_notGeneratingAtlasDefaultMetallic;

	private float m_notGeneratingAtlasDefaultGlossiness;

	private Color m_notGeneratingAtlasDefaultEmisionColor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool DoesShaderNameMatch(string shaderName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public TextureBlenderStandardMetallic()
	{
	}
}
