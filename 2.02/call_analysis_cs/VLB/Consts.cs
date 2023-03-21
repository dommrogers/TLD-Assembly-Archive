using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class Consts
{
	private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

	public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

	public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

	public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

	public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

	public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

	public const string HelpUrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

	public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

	public static readonly bool ProceduralObjectsVisibleInEditor;

	public static readonly Color FlatColor;

	public const ColorMode ColorModeDefault = ColorMode.Flat;

	public const float IntensityDefault = 1f;

	public const float IntensityMin = 0f;

	public const float IntensityMax = 8f;

	public const float SpotAngleDefault = 35f;

	public const float SpotAngleMin = 0.1f;

	public const float SpotAngleMax = 179.9f;

	public const float ConeRadiusStart = 0.1f;

	public const MeshType GeomMeshType = MeshType.Shared;

	public const int GeomSidesDefault = 18;

	public const int GeomSidesMin = 3;

	public const int GeomSidesMax = 256;

	public const int GeomSegmentsDefault = 5;

	public const int GeomSegmentsMin = 0;

	public const int GeomSegmentsMax = 64;

	public const bool GeomCap = false;

	public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

	public const float AttenuationCustomBlending = 0.5f;

	public const float FallOffStart = 0f;

	public const float FallOffEnd = 3f;

	public const float FallOffDistancesMinThreshold = 0.01f;

	public const float DepthBlendDistance = 2f;

	public const float CameraClippingDistance = 0.5f;

	public const float FresnelPowMaxValue = 10f;

	public const float FresnelPow = 8f;

	public const float GlareFrontal = 0.5f;

	public const float GlareBehind = 0.5f;

	public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

	public const float NoiseIntensityMin = 0f;

	public const float NoiseIntensityMax = 1f;

	public const float NoiseIntensityDefault = 0.5f;

	public const float NoiseScaleMin = 0.01f;

	public const float NoiseScaleMax = 2f;

	public const float NoiseScaleDefault = 0.5f;

	public static readonly Vector3 NoiseVelocityDefault;

	public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

	public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

	public const float FadeOutBeginDefault = -150f;

	public const float FadeOutEndDefault = -200f;

	public const Dimensions DimensionsDefault = Dimensions.Dim3D;

	public static readonly Vector2 TiltDefault;

	public static readonly Vector3 SkewingLocalForwardDirectionDefault;

	public const Transform ClippingPlaneTransformDefault = null;

	public static readonly LayerMask DynOcclusionLayerMaskDefault;

	public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

	public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

	public const int DynOcclusionWaitFramesCountDefault = 3;

	public const Dimensions DynOcclusionRaycastingDimensionsDefault = Dimensions.Dim3D;

	public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

	public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

	public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

	public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

	public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

	public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

	public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

	public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

	public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

	public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

	public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

	public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

	public const bool ConfigGeometryOverrideLayerDefault = true;

	public const int ConfigGeometryLayerIDDefault = 1;

	public const string ConfigGeometryTagDefault = "Untagged";

	public const string ConfigFadeOutCameraTagDefault = "MainCamera";

	public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

	public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

	public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.SinglePass;

	public const int ConfigNoise3DSizeDefault = 64;

	public const int ConfigSharedMeshSides = 24;

	public const int ConfigSharedMeshSegments = 5;

	public const float ConfigDitheringFactor = 0f;

	public const bool ConfigFeatureEnabledDefault = true;

	public const FeatureEnabledColorGradient ConfigFeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;

	public static HideFlags ProceduralObjectsHideFlags
	{
		[CalledBy(Type = typeof(MaterialManager), Member = "NewMaterialTransient")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[CalledBy(Type = typeof(Config), Member = "NewVolumetricDustParticles")]
		[CalledBy(Type = typeof(GlobalMesh), Member = "Get")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 7)]
		get
		{
			return default(HideFlags);
		}
	}
}
