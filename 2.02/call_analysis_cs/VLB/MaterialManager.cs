using System.Collections;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB;

public static class MaterialManager
{
	public enum BlendingMode
	{
		Additive,
		SoftAdditive,
		TraditionalTransparency,
		Count
	}

	public enum Noise3D
	{
		Off,
		On,
		Count
	}

	public enum DepthBlend
	{
		Off,
		On,
		Count
	}

	public enum ColorGradient
	{
		Off,
		MatrixLow,
		MatrixHigh,
		Count
	}

	public enum DynamicOcclusion
	{
		Off,
		ClippingPlane,
		DepthTexture,
		Count
	}

	public enum MeshSkewing
	{
		Off,
		On,
		Count
	}

	public enum ShaderAccuracy
	{
		Fast,
		High,
		Count
	}

	public class StaticProperties
	{
		public BlendingMode blendingMode;

		public Noise3D noise3D;

		public DepthBlend depthBlend;

		public ColorGradient colorGradient;

		public DynamicOcclusion dynamicOcclusion;

		public MeshSkewing meshSkewing;

		public ShaderAccuracy shaderAccuracy;

		private int blendingModeID
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			get
			{
				return default(int);
			}
		}

		private int noise3DID
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		private int depthBlendID
		{
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			get
			{
				return default(int);
			}
		}

		private int colorGradientID
		{
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		private int dynamicOcclusionID
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		private int meshSkewingID
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		private int shaderAccuracyID
		{
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		public int materialID
		{
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 6)]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[Calls(Type = typeof(Config), Member = "get_Instance")]
			[CalledBy(Type = typeof(MaterialManager), Member = "GetInstancedMaterial")]
			[CallsUnknownMethods(Count = 6)]
			get
			{
				return default(int);
			}
		}

		[Calls(Type = typeof(Material), Member = "SetInt")]
		[Calls(Type = typeof(Material), Member = "SetInt")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[CalledBy(Type = typeof(MaterialManager), Member = "GetInstancedMaterial")]
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
		[CallerCount(Count = 2)]
		public void ApplyToMaterial(Material mat)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public StaticProperties()
		{
		}
	}

	private class MaterialsGroup
	{
		public Material[] materials;

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public MaterialsGroup()
		{
		}
	}

	public static MaterialPropertyBlock materialPropertyBlock;

	private static readonly BlendMode[] BlendingMode_SrcFactor;

	private static readonly BlendMode[] BlendingMode_DstFactor;

	private static readonly bool[] BlendingMode_AlphaAsBlack;

	private static int kStaticPropertiesCount;

	private static Hashtable ms_MaterialsGroup;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[CalledBy(Type = typeof(MaterialManager), Member = "GetInstancedMaterial")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(MaterialManager), Member = "NewMaterialPersistent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static Material NewMaterialTransient(bool gpuInstanced)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(MaterialManager), Member = "NewMaterialTransient")]
	[CallsUnknownMethods(Count = 9)]
	public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
	{
		return null;
	}

	[Calls(Type = typeof(MaterialManager), Member = "NewMaterialTransient")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
	[Calls(Type = typeof(StaticProperties), Member = "ApplyToMaterial")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StaticProperties), Member = "get_materialID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
	{
		return null;
	}
}
