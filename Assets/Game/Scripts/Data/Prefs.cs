using UnityEngine;

namespace TicTacToe
{
    public static class Prefs
    {
        public static bool TryGetValue(string name, out float value)
        {
            if (PlayerPrefs.HasKey(name))
            {
                value = PlayerPrefs.GetFloat(name);
                return true;
            }

            value = default;
            return false;
        }

        public static bool TryGetValue(string name, out int value)
        {
            if (PlayerPrefs.HasKey(name))
            {
                value = PlayerPrefs.GetInt(name);
                return true;
            }

            value = default;
            return false;
        }

        public static bool TryGetValue(string name, out string value)
        {
            if (PlayerPrefs.HasKey(name))
            {
                value = PlayerPrefs.GetString(name);
                return true;
            }

            value = default;
            return false;
        }
    }
}
