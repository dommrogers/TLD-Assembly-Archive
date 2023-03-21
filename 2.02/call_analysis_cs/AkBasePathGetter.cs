using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkBasePathGetter
{
	public static string DefaultBasePath;

	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetPlatformName()
	{
		return null;
	}

	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "Start")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadNonLocalizedBank")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadLocalizedBank")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "GetDecodedBankFullPath")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformName")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetPlatformBasePath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetFullSoundBankPath()
	{
		return null;
	}

	[CalledBy(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "TrimStart")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash)
	{
	}

	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetFullSoundBankPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void FixSlashes(ref string path)
	{
	}

	[CalledBy(TypeFullName = "AkBankManager.DecodableBankHandle", Member = ".ctor")]
	[CalledBy(TypeFullName = "AkBankManager.DecodableBankHandle", Member = "DoLoadBank")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetSoundbankBasePath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AkBasePathGetter()
	{
	}
}
