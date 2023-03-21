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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return default(bool);
		}
	}

	public int particlesCurrentCount
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return default(int);
		}
	}

	public int particlesMaxCount
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

	public Camera mainCamera
	{
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "NewVolumetricDustParticles")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	private void InstantiateParticleSystem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void SetActiveAndPlay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Gradient), Member = "get_colorKeys")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[Calls(Type = typeof(Gradient), Member = "get_alphaKeys")]
	[Calls(Type = typeof(Gradient), Member = "Equals")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	private void SetParticleProperties()
	{
	}

	[CallerCount(Count = 0)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_bounds")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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
