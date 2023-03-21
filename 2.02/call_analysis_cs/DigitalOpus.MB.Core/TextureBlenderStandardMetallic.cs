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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	public bool DoesShaderNameMatch(string shaderName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
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
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = ".ctor")]
	public TextureBlenderStandardMetallic()
	{
	}
}
