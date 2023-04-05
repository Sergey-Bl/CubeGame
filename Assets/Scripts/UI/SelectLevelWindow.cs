using Configs;
using UnityEngine;

namespace UI
{
    public class SelectLevelWindow : MonoBehaviour
    {
        [SerializeField] private LevelButton _levelButtonPrefab;
        [SerializeField] private RectTransform _content;

        [SerializeField] private LevelsConfigs _levelsConfigs;

        private void Awake()
        {
            for (int i = 0; i < _levelsConfigs.Levels.Length; i++)
            {
                var buttonInstance = Instantiate(_levelButtonPrefab, _content);

                var LevelConfig = _levelsConfigs.Levels[i];

                bool active = LevelConfig.Completed ||
                              (i - 1 >= 0 &&
                               _levelsConfigs.Levels[i - 1].Completed) ||
                              i == 0;

                buttonInstance.DrawLevel(
                    (i + 1).ToString(),
                    LevelConfig.SceneName,
                    active
                );
            }
        }
    }
}