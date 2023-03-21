public interface IRichPresenceProvider
{
	void Initialize();

	void Shutdown();

	void Update();

	void SetLocalizationKeys(RichPresenceLocInfo[] locKeys);

	void SetPresence(PresenceType presenceType);
}
