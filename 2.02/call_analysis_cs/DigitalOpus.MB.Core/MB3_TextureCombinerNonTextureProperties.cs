using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB3_TextureCombinerNonTextureProperties
{
	public interface MaterialProperty
	{
		string PropertyName
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 121780)]
			get;
			[CallerCount(Count = 121780)]
			[DeduplicatedMethod]
			set;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		MaterialPropertyValueAveraged GetAverageCalculator();

		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		object GetDefaultValue();
	}

	public class MaterialPropertyFloat : MaterialProperty
	{
		private string _003CPropertyName_003Ek__BackingField;

		private MaterialPropertyValueAveragedFloat _averageCalc;

		private float _defaultValue;

		public string PropertyName
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 52)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 101)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		public MaterialPropertyFloat(string name, float defValue)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		public MaterialPropertyValueAveraged GetAverageCalculator()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public object GetDefaultValue()
		{
			return null;
		}
	}

	public class MaterialPropertyColor : MaterialProperty
	{
		private string _003CPropertyName_003Ek__BackingField;

		private MaterialPropertyValueAveragedColor _averageCalc;

		private Color _defaultValue;

		public string PropertyName
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 52)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 101)]
			[CompilerGenerated]
			set
			{
			}
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		public MaterialPropertyColor(string name, Color defaultVal)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		public MaterialPropertyValueAveraged GetAverageCalculator()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public object GetDefaultValue()
		{
			return null;
		}
	}

	public interface MaterialPropertyValueAveraged
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		object GetAverage();

		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		int NumValues();

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property);
	}

	public class MaterialPropertyValueAveragedFloat : MaterialPropertyValueAveraged
	{
		public float averageVal;

		public int numValues;

		[Calls(Type = typeof(Material), Member = "GetFloat")]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public object GetAverage()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public int NumValues()
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "SetFloat")]
		[CallsUnknownMethods(Count = 8)]
		public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public MaterialPropertyValueAveragedFloat()
		{
		}
	}

	public class MaterialPropertyValueAveragedColor : MaterialPropertyValueAveraged
	{
		public Color averageVal;

		public int numValues;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "GetColor")]
		[CallsUnknownMethods(Count = 4)]
		public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public object GetAverage()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		public int NumValues()
		{
			return default(int);
		}

		[Calls(Type = typeof(Material), Member = "SetColor")]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public MaterialPropertyValueAveragedColor()
		{
		}
	}

	public struct TexPropertyNameColorPair
	{
		public string name;

		public Color color;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public TexPropertyNameColorPair(string nm, Color col)
		{
		}
	}

	private interface NonTextureProperties
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		bool NonTexturePropertiesAreEqual(Material a, Material b);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty);

		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty);
	}

	private class NonTexturePropertiesDontBlendProps : NonTextureProperties
	{
		private MB3_TextureCombinerNonTextureProperties _textureProperties;

		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		public NonTexturePropertiesDontBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[CallsUnknownMethods(Count = 13)]
		public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		public Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}
	}

	private class NonTexturePropertiesBlendProps : NonTextureProperties
	{
		private MB3_TextureCombinerNonTextureProperties _textureProperties;

		private TextureBlender resultMaterialTextureBlender;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public NonTexturePropertiesBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties, TextureBlender resultMats)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 21)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log")]
		public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}
	}

	public static Color NEUTRAL_NORMAL_MAP_COLOR;

	private TexPropertyNameColorPair[] defaultTextureProperty2DefaultColorMap;

	private MaterialProperty[] _nonTextureProperties;

	private MB2_LogLevel LOG_LEVEL;

	private bool _considerNonTextureProperties;

	private TextureBlender resultMaterialTextureBlender;

	private TextureBlender[] textureBlenders;

	private Dictionary<string, Color> textureProperty2DefaultColorMap;

	private NonTextureProperties _nonTexturePropertiesBlender;

	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
	[Calls(Type = typeof(MaterialPropertyColor), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	[CallsUnknownMethods(Count = 130)]
	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyColor), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	public MB3_TextureCombinerNonTextureProperties(MB2_LogLevel ll, bool considerNonTextureProps)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallerCount(Count = 1)]
	internal void CollectAverageValuesOfNonTextureProperties(Material resultMaterial, Material mat)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlenders")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "FindBestTextureBlender")]
	internal void LoadTextureBlendersIfNeeded(Material resultMaterial)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 1)]
	private static bool InterfaceFilter(Type typeObj, object criteriaObj)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlendersIfNeeded")]
	[CalledBy(Type = typeof(MB3_TextureCombiner._003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private void FindBestTextureBlender(Material resultMaterial)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(MB3_TextureCombiner._003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlendersIfNeeded")]
	[CallsUnknownMethods(Count = 51)]
	private void LoadTextureBlenders()
	{
	}

	[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MB_TexSet), Member = "IsEqual")]
	internal bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCopyScaledAndTiledToAtlas_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	internal Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	internal void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
	internal Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "CopyScaledAndTiledToAtlas")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
	[CallsUnknownMethods(Count = 2)]
	internal Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private TextureBlender FindMatchingTextureBlender(string shaderName)
	{
		return null;
	}
}
