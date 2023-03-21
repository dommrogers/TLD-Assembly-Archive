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
		string PropertyName { get; set; }

		MaterialPropertyValueAveraged GetAverageCalculator();

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
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 103)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public MaterialPropertyFloat(string name, float defValue)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
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
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 103)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public MaterialPropertyColor(string name, Color defaultVal)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
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
		void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property);

		object GetAverage();

		int NumValues();

		void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property);
	}

	public class MaterialPropertyValueAveragedFloat : MaterialPropertyValueAveraged
	{
		public float averageVal;

		public int numValues;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "GetFloat")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 6)]
		public int NumValues()
		{
			return 0;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "SetFloat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MaterialPropertyValueAveragedFloat()
		{
		}
	}

	public class MaterialPropertyValueAveragedColor : MaterialPropertyValueAveraged
	{
		public Color averageVal;

		public int numValues;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "GetColor")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "SetColor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
		bool NonTexturePropertiesAreEqual(Material a, Material b);

		Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName);

		void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods);

		Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty);

		Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty);
	}

	private class NonTexturePropertiesDontBlendProps : NonTextureProperties
	{
		private MB3_TextureCombinerNonTextureProperties _textureProperties;

		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		public NonTexturePropertiesDontBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 2)]
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
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 21)]
		public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyColor), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyFloat), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 130)]
	public MB3_TextureCombinerNonTextureProperties(MB2_LogLevel ll, bool considerNonTextureProps)
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
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
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool InterfaceFilter(Type typeObj, object criteriaObj)
	{
		return false;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<_CombineTexturesIntoAtlases>d__69", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlendersIfNeeded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	private void FindBestTextureBlender(Material resultMaterial)
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<_CombineTexturesIntoAtlases>d__69", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlendersIfNeeded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 51)]
	private void LoadTextureBlenders()
	{
	}

	[CalledBy(Type = typeof(MB_TexSet), Member = "IsEqual")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "AllTexturesAreSameForMerge")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return false;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CopyScaledAndTiledToAtlas>d__1", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(MB_TextureCombinerRenderTexture), Member = "CopyScaledAndTiledToAtlas")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private TextureBlender FindMatchingTextureBlender(string shaderName)
	{
		return null;
	}
}
