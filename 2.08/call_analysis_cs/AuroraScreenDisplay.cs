using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.ModularElectrolizer;
using UnityEngine;

public class AuroraScreenDisplay : MonoBehaviour
{
	public enum State
	{
		Uninitialized,
		Off,
		Low,
		Stable
	}

	private bool m_IsDigital;

	private CustomCameraPosition m_InspectComponent;

	private AuroraScreenPrefabPool m_DisplayInterfacePrefabPool;

	private int m_RenderTextureWidth;

	private int m_RenderTextureHeight;

	private float m_InspectionResolveSpeed;

	private MinMax m_DistortionToggleRate;

	private MinMax m_VSyncRate;

	public ObjectGuid m_Guid;

	private GameObject m_DisplayInterface;

	private Camera m_RenderTextureCamera;

	private RenderTexture m_InterfaceRenderTexture;

	private InteractiveScrollText m_InteractiveScrollText;

	private AuroraScreenAudio m_DisplayAudio;

	private State m_State;

	private AuroraModularElectrolizer m_LocalElectrolizer;

	private float m_DistortionTime;

	private float m_DistortionTimer;

	private float m_VSyncTime;

	private float m_VSyncTimer;

	private float m_VSyncPrev;

	private float m_VSyncNext;

	private float m_DefaultDistortion;

	private float m_InspectDistortion;

	private float m_InspectDistortionTarget;

	private Renderer m_LocalDisplay;

	private Color m_OriginalColor;

	private Color m_NewColor;

	private string m_LanguageUsedForLocalize;

	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateAnalogEffect")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateDigitalEffect")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(RenderTexture), Member = "Create")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	private void InitializeDisplayInterface()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void UpdateDigitalEffect()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAnalogEffect()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	private void UpdateInteractiveScrolling()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CallsUnknownMethods(Count = 5)]
	private void SetDisplayActive(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	private void SetState(State state)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[CalledBy(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[CallsUnknownMethods(Count = 1)]
	public string GetPrefabName()
	{
		return null;
	}

	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[Calls(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	private void OnCameraPositionStateChange(CustomCameraPosition.State newCameraState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	private void OnTextScrolled()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "RefreshLocalization")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshLocalization()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AuroraScreenDisplay()
	{
	}
}
