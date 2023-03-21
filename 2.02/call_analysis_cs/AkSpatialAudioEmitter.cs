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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 22)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkSpatialAudioEmitter()
	{
	}
}
