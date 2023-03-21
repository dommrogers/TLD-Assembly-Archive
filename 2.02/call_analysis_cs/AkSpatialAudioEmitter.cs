using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;

public class AkSpatialAudioEmitter : AkSpatialAudioBase
{
	public AuxBus reflectAuxBus;

	public float reflectionMaxPathLength;

	public float reflectionsAuxBusGain;

	public uint reflectionsOrder;

	public float roomReverbAuxBusGain;

	public uint diffractionMaxEdges;

	public uint diffractionMaxPaths;

	public uint diffractionMaxPathLength;

	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AkSpatialAudioEmitter()
	{
	}
}
