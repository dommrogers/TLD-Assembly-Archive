using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderMaterialPropertyCacheHelper
{
	private struct MaterialPropertyPair
	{
		public Material material;

		public string property;

		[DeduplicatedMethod]
		[CallerCount(Count = 67)]
		public MaterialPropertyPair(Material m, string prop)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ValueType), Member = "GetHashCode")]
		[CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	private Dictionary<MaterialPropertyPair, object> nonTexturePropertyValuesForSourceMaterials;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CalledBy(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[CallsUnknownMethods(Count = 10)]
	private bool AllNonTexturePropertyValuesAreEqual(string prop)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "GetColorIfNoTexture")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "GetColorIfNoTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "GetColorIfNoTexture")]
	public void CacheMaterialProperty(Material m, string property, object value)
	{
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "AllNonTexturePropertyValuesAreEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	public object GetValueIfAllSourceAreTheSameOrDefault(string property, object defaultValue)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = ".ctor")]
	public TextureBlenderMaterialPropertyCacheHelper()
	{
	}
}
