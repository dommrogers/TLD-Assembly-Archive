using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderStandardMetallicRoughness : TextureBlender
{
	private enum Prop
	{
		doColor,
		doMetallic,
		doRoughness,
		doEmission,
		doBump,
		doNone
	}

	private static Color NeutralNormalMap;

	private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

	private Color m_tintColor;

	private float m_roughness;

	private float m_metallic;

	private bool m_hasMetallicGlossMap;

	private bool m_hasSpecGlossMap;

	private float m_bumpScale;

	private bool m_shaderDoesEmission;

	private Color m_emissionColor;

	private Prop propertyToDo;

	private Color m_generatingTintedAtlasColor;

	private float m_generatingTintedAtlasMetallic;

	private float m_generatingTintedAtlasRoughness;

	private float m_generatingTintedAtlasBumpScale;

	private Color m_generatingTintedAtlasEmission;

	private Color m_notGeneratingAtlasDefaultColor;

	private float m_notGeneratingAtlasDefaultMetallic;

	private float m_notGeneratingAtlasDefaultGlossiness;

	private Color m_notGeneratingAtlasDefaultEmisionColor;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 1)]
	public bool DoesShaderNameMatch(string shaderName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(string), Member = "Equals")]
	public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
	{
		return default(Color);
	}

	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(string), Member = "Equals")]
	public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
	{
		return default(Color);
	}

	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public TextureBlenderStandardMetallicRoughness()
	{
	}
}
