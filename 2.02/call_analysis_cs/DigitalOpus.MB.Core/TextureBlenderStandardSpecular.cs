using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderStandardSpecular : TextureBlender
{
	private enum Prop
	{
		doColor,
		doSpecular,
		doEmission,
		doBump,
		doNone
	}

	private static Color NeutralNormalMap;

	private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

	private Color m_tintColor;

	private float m_glossiness;

	private float m_SpecGlossMapScale;

	private Color m_specColor;

	private bool m_hasSpecGlossMap;

	private float m_bumpScale;

	private bool m_shaderDoesEmission;

	private Color m_emissionColor;

	private Prop propertyToDo;

	private Color m_generatingTintedAtlaColor;

	private Color m_generatingTintedAtlaSpecular;

	private float m_generatingTintedAtlaGlossiness;

	private float m_generatingTintedAtlaSpecGlossMapScale;

	private float m_generatingTintedAtlaBumpScale;

	private Color m_generatingTintedAtlaEmission;

	private Color m_notGeneratingAtlasDefaultColor;

	private Color m_notGeneratingAtlasDefaultSpecularColor;

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

	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
	{
	}

	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
	{
		return default(Color);
	}

	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "CacheMaterialProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextureBlenderStandardSpecular()
	{
	}
}
