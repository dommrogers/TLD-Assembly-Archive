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
			return false;
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
			return false;
		}
	}

	public int particlesCurrentCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public int particlesMaxCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public Camera mainCamera
	{
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "NewVolumetricDustParticles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void InstantiateParticleSystem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "Start")]
	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetActiveAndPlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetActiveAndPlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Gradient), Member = "Equals")]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys")]
	[Calls(Type = typeof(Gradient), Member = "get_alphaKeys")]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 46)]
	private void SetParticleProperties()
	{
	}

	[CallerCount(Count = 0)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(VolumetricDustParticles), Member = "get_mainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateCulling()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public VolumetricDustParticles()
	{
	}
}
