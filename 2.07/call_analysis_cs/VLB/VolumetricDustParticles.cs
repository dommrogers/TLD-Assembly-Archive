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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool particlesAreInstantiated
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return default(bool);
		}
	}

	public int particlesCurrentCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public int particlesMaxCount
	{
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public Camera mainCamera
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[Calls(Type = typeof(Config), Member = "NewVolumetricDustParticles")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	private void InstantiateParticleSystem()
	{
	}

	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 4)]
	private void SetActiveAndPlay()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(Gradient), Member = "get_alphaKeys")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Gradient), Member = "Equals")]
	private void SetParticleProperties()
	{
	}

	[CallerCount(Count = 0)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void UpdateCulling()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public VolumetricDustParticles()
	{
	}
}
