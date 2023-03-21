using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class CameraGlobalRT : MonoBehaviour
{
	public Camera m_WorldCamera;

	public Camera m_WeaponCamera;

	public Camera m_InspectCamera;

	public Camera m_ImageEffectCamera;

	private int m_RenderTextureSizePadding;

	private float m_SsaoFieldOfViewScalar;

	public Camera m_OverrideCamera;

	public bool m_OverrideCameraParamsOnly;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	private PanelReference<Panel_Credits> m_Credits;

	private PanelReference<Panel_FeedFire> m_FeedFire;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Log> m_LogPanel;

	private Camera m_Camera;

	private RenderTexture m_MainRenderTexture;

	private RenderTexture m_InspectRenderTexture;

	private int m_LastWidth;

	private int m_LastHeight;

	private CameraClearFlags m_OriginalClearFlags;

	private bool m_Rendered;

	private Material m_MainBlitMaterial;

	private UITexture m_UITextureForInspect;

	private bool m_IsRendering;

	private bool m_HighResRender;

	public int m_HighResCanvasX;

	public int m_HighResCanvasY;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseMainRenderTarget")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	private void Start()
	{
	}

	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MatchWorldCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseMainRenderTarget")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MatchWorldCamera")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsGameplayRendering")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth")]
	[Calls(Type = typeof(Shader), Member = "EnableKeyword")]
	[Calls(Type = typeof(Shader), Member = "DisableKeyword")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "GetInspectCameraUITexture")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	private void OnPreRender()
	{
	}

	[Calls(Type = typeof(LightingManager), Member = "TransformLightPositions")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	private void RenderScene(RenderTexture targetRenderTexture, int width, int height, bool renderWeaponCamera)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void InspectCameraToUITexture(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ScaledBlit")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "InspectCameraToUITexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "GetRenderTexture")]
	private void MaybeReassignRenderTexture(ref RenderTexture texture, int width, int height)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private RenderTexture GetRenderTexture(int width, int height)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	private RenderTexture GetTemporaryRenderTexture(int width, int height)
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "InspectCameraToUITexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	private void RenderCamera(Camera camera, RenderTexture target, int width, int height)
	{
	}

	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void MaybeRenderInspectCamera(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	private UITexture GetInspectCameraUITexture()
	{
		return null;
	}

	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnRenderImage")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Material), Member = "SetPass")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	private void ScaledBlit(RenderTexture source, RenderTexture destination)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void ReleaseMainRenderTarget()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 2)]
	private void ReleaseInspectRenderTargets()
	{
	}

	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	private void MatchWorldCamera()
	{
	}

	[CallerCount(Count = 0)]
	public void StopRendering()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void StartRendering()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 49)]
	public RenderTexture GetRenderTexture()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void HighResRender(bool isHighRes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetRenderTextureSizePadding()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private static void OnResourceAvailabilityChanged(bool amConstrained)
	{
	}

	[CallerCount(Count = 0)]
	public CameraGlobalRT()
	{
	}
}
