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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(ObjectGuid), Member = "Generate")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 28)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTexture), Member = "Create")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateDigitalEffect")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateAnalogEffect")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	private void InitializeDisplayInterface()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateDigitalEffect()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateAnalogEffect()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateInteractiveScrolling()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	private void SetDisplayActive(bool enable)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "SetInt")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void SetState(State state)
	{
	}

	[CalledBy(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetPrefabName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "SetScrollingEnabled")]
	[Calls(Type = typeof(MissionManagerBase), Member = "SendMissionEvent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(CollectionManager), Member = "UnlockAuroraScreen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnCameraPositionStateChange(CustomCameraPosition.State newCameraState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTextScrolled()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "RefreshLocalization")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshLocalization()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public AuroraScreenDisplay()
	{
	}
}
