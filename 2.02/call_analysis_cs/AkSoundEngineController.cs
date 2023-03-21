using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkSoundEngineController
{
	private static AkSoundEngineController ms_Instance;

	public static AkSoundEngineController Instance
	{
		[CalledBy(Type = typeof(AkInitializer), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnDisable")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationPause")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationFocus")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationQuit")]
		[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private AkSoundEngineController()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AkSoundEngineController()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetDecodedBankFolder()
	{
		return null;
	}

	[CalledBy(TypeFullName = "AkBankManager.DecodableBankHandle", Member = ".ctor")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string GetDecodedBankFullPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkBankManager), Member = "DoUnloadBanks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(AkInitializer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Init(AkInitializer akInitializer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Terminate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnApplicationFocus(bool focus)
	{
	}

	[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationPause")]
	[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationFocus")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "OnApplicationPause")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void ActivateAudio(bool activate, bool renderAnyway = false)
	{
	}
}
