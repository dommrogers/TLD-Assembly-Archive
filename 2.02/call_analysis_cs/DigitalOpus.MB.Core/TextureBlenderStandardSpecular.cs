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
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareFloat")]
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
	public TextureBlenderStandardSpecular()
	{
	}
}
