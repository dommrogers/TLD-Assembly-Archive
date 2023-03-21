using System;
using Cpp2ILInjected.CallAnalysis;
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

	private AuroraElectrolizer m_LocalElectrolizer;

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

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[Calls(Type = typeof(ObjectGuid), Member = "Generate")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(RenderTexture), Member = "Create")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateAnalogEffect")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateDigitalEffect")]
	private void Update()
	{
	}

	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	private void InitializeDisplayInterface()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateDigitalEffect()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateAnalogEffect()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateInteractiveScrolling()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallerCount(Count = 4)]
	private void SetDisplayActive(bool enable)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	private void SetState(State state)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[CalledBy(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[CallsUnknownMethods(Count = 1)]
	public string GetPrefabName()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CallerCount(Count = 0)]
	private void OnCameraPositionStateChange(CustomCameraPosition.State newCameraState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTextScrolled()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "RefreshLocalization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	private void RefreshLocalization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AuroraScreenDisplay()
	{
	}
}
