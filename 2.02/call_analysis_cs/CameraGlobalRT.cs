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
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseMainRenderTarget")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "PrepareCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsGameplayRendering")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseMainRenderTarget")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Shader), Member = "EnableKeyword")]
	[Calls(Type = typeof(Shader), Member = "DisableKeyword")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ReleaseInspectRenderTargets")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "GetInspectCameraUITexture")]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight")]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnPreRender()
	{
	}

	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(LightingManager), Member = "TransformLightPositions")]
	[Calls(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[Calls(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	private void RenderScene(RenderTexture targetRenderTexture, int width, int height, bool renderWeaponCamera)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[CallsUnknownMethods(Count = 2)]
	private void InspectCameraToUITexture(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "ScaledBlit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "GetRenderTexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "InspectCameraToUITexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeReassignRenderTexture(ref RenderTexture texture, int width, int height)
	{
	}

	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
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

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "InspectCameraToUITexture")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "MaybeRenderInspectCamera")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	private void RenderCamera(Camera camera, RenderTexture target, int width, int height)
	{
	}

	[Calls(Type = typeof(CameraGlobalRT), Member = "RenderCamera")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraGlobalRT), Member = "MaybeReassignRenderTexture")]
	private void MaybeRenderInspectCamera(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsUnknownMethods(Count = 27)]
	private UITexture GetInspectCameraUITexture()
	{
		return null;
	}

	[Calls(Type = typeof(GL), Member = "TexCoord2")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[Calls(Type = typeof(GL), Member = "TexCoord2")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnRenderImage")]
	[Calls(Type = typeof(GL), Member = "TexCoord2")]
	[Calls(Type = typeof(GL), Member = "Vertex3")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GL), Member = "TexCoord2")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(Material), Member = "SetPass")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ScaledBlit(RenderTexture source, RenderTexture destination)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 2)]
	private void ReleaseMainRenderTarget()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
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
	[CallerCount(Count = 10)]
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
		return default(int);
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void OnResourceAvailabilityChanged(bool amConstrained)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraGlobalRT()
	{
	}
}
