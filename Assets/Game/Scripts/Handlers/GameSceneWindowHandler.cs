using UnityEngine;

namespace TicTacToe
{
    public class GameSceneWindowHandler : MonoBehaviour, IHandler
    {
        [SerializeField] private EndWindow _endWindow;
        [SerializeField] private GameWindow _gameWindow;
        [SerializeField] private SoundWindow _soundWindow;

        private void OnEnable()
        {
            _gameWindow.OnSoundButtonClicked += OpenSoundWindow;
            _endWindow.OnRestartButtonClicked += CloseSoundWindow;

            _soundWindow.OnBackgroundButtonClicked += CloseSoundWindow;
            _soundWindow.OnSoundValueChanged += SaveSoundValue;
        }

        private void OnDisable()
        {
            _gameWindow.OnSoundButtonClicked -= OpenSoundWindow;
            _endWindow.OnRestartButtonClicked -= ReloadScene;

            _soundWindow.OnBackgroundButtonClicked -= CloseSoundWindow;
            _soundWindow.OnSoundValueChanged -= SaveSoundValue;
        }

        private void ReloadScene()
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
