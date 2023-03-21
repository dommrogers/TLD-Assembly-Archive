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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isNoiseEnabled")]
		[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public static bool isProperlyLoaded
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	public static string isNotSupportedString
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static void OnStartUp()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Noise3D), Member = "LoadTexture3D")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	public static void LoadIfNeeded()
	{
	}

	[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 22)]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
