using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class VolumetricDustParticles : MonoBehaviour
{
	public float alpha;

	public float size;

	public ParticlesDirection direction;

	public Vector3 velocity;

	public float speed;

	public float density;

	public float spawnMinDistance;

	public float spawnMaxDistance;

	public bool cullingEnabled;

	public float cullingMaxDistance;

	private bool _003CisCulled_003Ek__BackingField;

	public static bool isFeatureSupported;

	private ParticleSystem m_Particles;

	private ParticleSystemRenderer m_Renderer;

	private static bool ms_NoMainCameraLogged;

	private static Camera ms_MainCamera;

	private float m_CachedAlpha;

	private Gradient m_CachedGradient;

	private VolumetricLightBeam m_Master;

	public bool isCulled
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool particlesAreInstantiated
	{
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public int particlesCurrentCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public int particlesMaxCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public Camera mainCamera
	{
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Config), Member = "NewVolumetricDustParticles")]
	private void InstantiateParticleSystem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "OnEnable")]
	private void SetActiveAndPlay()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 70)]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "ComputeConeRadiusEnd")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Gradient), Member = "get_alphaKeys")]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys")]
	[Calls(Type = typeof(Gradient), Member = "Equals")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_usedColorMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
	private void SetParticleProperties()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateCulling()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public VolumetricDustParticles()
	{
	}
}
