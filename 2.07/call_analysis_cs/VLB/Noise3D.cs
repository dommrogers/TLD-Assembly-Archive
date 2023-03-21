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
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isNoiseEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return false;
		}
	}

	public static bool isProperlyLoaded
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public static string isNotSupportedString
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(Noise3D), Member = "OnStartUp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Noise3D), Member = "LoadTexture3D")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void LoadIfNeeded()
	{
	}

	[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
