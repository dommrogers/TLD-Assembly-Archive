using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkInitializer : MonoBehaviour
{
	private static AkInitializer ms_Instance;

	public AkWwiseInitializationSettings InitializationSettings;

	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(AkSoundEngineController), Member = "Init")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_Instance")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Calls(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CallsUnknownMethods(Count = 2)]
	private void OnApplicationFocus(bool focus)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	private void OnApplicationQuit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkBankManager), Member = "DoUnloadBanks")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkInitializer()
	{
	}
}
