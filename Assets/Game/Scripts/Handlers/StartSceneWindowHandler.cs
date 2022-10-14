using UnityEngine;

namespace TicTacToe
{
    public class StartSceneWindowHandler : MonoBehaviour, IHandler
    {
        [SerializeField] private StartWindow _startWindow;
        [SerializeField] private SoundWindow _soundWindow;

        private void OnEnable()
        {
            _startWindow.OnSoundButtonClicked += OpenSoundWindow;
            _startWindow.OnStartButtonClicked += OpenGameScene;

            _soundWindow.OnBackgroundButtonClicked += CloseSoundWindow;
            _soundWindow.OnSoundValueChanged += SaveSoundValue;
        }

        private void OnDisable()
        {
            _startWindow.OnSoundButtonClicked -= OpenSoundWindow;
            _startWindow.OnStartButtonClicked -= OpenGameScene;

            _soundWindow.OnBackgroundButtonClicked -= CloseSoundWindow;
            _soundWindow.OnSoundValueChanged -= SaveSoundValue;
        }

        private void OpenGameScene()
        {
            Scenes.Instance.SetScene(SceneType.Game);
        }

        private void OpenSoundWindow()
        {
            _soundWindow.Open();
        }

        private void CloseSoundWindow()
        {
            _soundWindow.Close();
        }

        private void SaveSoundValue(float value)
        {
            PlayerPrefs.SetFloat(PrefsNames.SoundValue, value);
        }
    }
}
