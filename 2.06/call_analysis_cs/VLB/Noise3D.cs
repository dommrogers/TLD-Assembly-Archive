using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class Noise3D
{
	private static bool ms_IsSupportedChecked;

	private static bool ms_IsSupported;

	private static Texture3D ms_NoiseTexture;

	private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

	private const int kMinShaderLevel = 35;

	public static bool isSupported
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isNoiseEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public static bool isProperlyLoaded
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public static string isNotSupportedString
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	private static void OnStartUp()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Noise3D), Member = "OnStartUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Noise3D), Member = "LoadTexture3D")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	public static void LoadIfNeeded()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
