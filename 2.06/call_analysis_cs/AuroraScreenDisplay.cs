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

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateDigitalEffect")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateAnalogEffect")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTexture), Member = "Create")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
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

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UpdateInteractiveScrolling()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void SetDisplayActive(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[Calls(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void OnCameraPositionStateChange(CustomCameraPosition.State newCameraState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTextScrolled()
	{
	}

	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	private void RefreshLocalization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	public AuroraScreenDisplay()
	{
	}
}
