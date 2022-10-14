using System;

namespace TicTacToe
{
    public interface ISoundSlider
    {
        public event Action<float> OnSoundValueChanged;
    }
}
