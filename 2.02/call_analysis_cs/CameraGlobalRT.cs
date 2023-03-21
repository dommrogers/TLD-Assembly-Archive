using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseMainRenderTarget")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseMainRenderTarget")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsGameplayRendering")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth")]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "GetInspectCameraUITexture")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Shader), Member = "DisableKeyword")]
	[Calls(Type = typeof(Shader), Member = "EnableKeyword")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 59)]
	private void OnPreRender()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[Calls(Type = typeof(LightingManager), Member = "TransformLightPositions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RenderScene(RenderTexture targetRenderTexture, int width, int height, bool renderWeaponCamera)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void InspectCameraToUITexture(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ScaledBlit")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "InspectCameraToUITexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "GetRenderTexture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeReassignRenderTexture(ref RenderTexture texture, int width, int height)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private RenderTexture GetRenderTexture(int width, int height)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	private RenderTexture GetTemporaryRenderTexture(int width, int height)
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "InspectCameraToUITexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private void RenderCamera(Camera camera, RenderTexture target, int width, int height)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeRenderInspectCamera(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 27)]
	private UITexture GetInspectCameraUITexture()
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnRenderImage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = "SetPass")]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[Calls(Type = typeof(GL), Member = "TexCoord2")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	private void ScaledBlit(RenderTexture source, RenderTexture destination)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ReleaseMainRenderTarget()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ReleaseInspectRenderTargets()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void StopRendering()
	{
	}

	[CallerCount(Count = 0)]
	public void StartRendering()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public RenderTexture GetRenderTexture()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void HighResRender(bool isHighRes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetRenderTextureSizePadding()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void OnResourceAvailabilityChanged(bool amConstrained)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraGlobalRT()
	{
	}
}
